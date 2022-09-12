using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;



namespace RocketChatLib
{
    public class RocketChat
    {

        private string user { get; set; }
        private string password { get; set; }

        private string BaseUrl { get; set; }

        private bool authenthicated { get; set; }

        private string userId { get; set; }
        private string authToken { get; set; }



        /// <summary>
        /// Отправка сообщений в канал 
        /// </summary>
        /// <param name="message">Текст сообщения</param>
        /// <param name="room">Имя канала. Можно получить доступные через ChannelList </param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public PostMessageResponse.Root PostMessage (string message , string room)
        {


            // отправка сообщений
            RestClient client = new RestClient(this.BaseUrl);
            RestRequest request = new RestRequest("chat.postMessage", Method.Post);
            request.AddHeader("Accept", @"application/json");
            request.AddHeader("X-Auth-Token", this.authToken);
            request.AddHeader("X-User-Id", this.userId);

            var msg = new
            {
                channel = room,
                text = message

            };

            /// не тот канал 
            /// {"success":false,"error":"[invalid-channel]","errorType":"invalid-channel"}



            request.AddJsonBody(msg);
            string content = client.Execute(request).Content;

            PostMessageResponse.Root pmResponse = JsonConvert.DeserializeObject<PostMessageResponse.Root>(content);
            if (pmResponse.success != true)
            {
                Console.WriteLine("Ошибка отправки сообщения");
                throw new ApplicationException("Post message error");

            }

            return pmResponse;

        }
        
        /// <summary>
        /// Получить список доступных каналов
        /// </summary>
        public ChannelList.Root ChannelList
        {
            get
            {
                if (!authenthicated)
                {
                    RocketChatLogin();
                }
                RestClient client = new RestClient(this.BaseUrl);
                RestRequest request = new RestRequest("channels.list", Method.Get);
                request.AddHeader("Accept", @"application/json");
                request.AddHeader("X-Auth-Token", this.authToken);
                request.AddHeader("X-User-Id", this.userId);

                string content = client.Execute(request).Content;

                this.ChannelList = JsonConvert.DeserializeObject<ChannelList.Root>(content);

                if (this.ChannelList.success != true)
                {
                    //Console.WriteLine("Ошибка получения списка каналов");
                    throw new ApplicationException("Channel list error");
                }
                return this.ChannelList;
            }
            set
            {
                this.ChannelList = value;
            }

        }
        
        /// <summary>
        /// Получаем полный URL по названию ресурса. На всякий случай рест шарп умеет и сам 
        /// </summary>
        /// <param name="resource"></param>
        /// <returns></returns>
        /// <exception cref="ApplicationException"></exception>
        public Uri GetUriForResource(string resource)
         {
                if (BaseUrl.IsNullOrEmpty())
                    throw new ApplicationException("Base url is null or empty");

                if (string.IsNullOrWhiteSpace(resource))
                    return new Uri(this.BaseUrl);

                return new Uri(this.BaseUrl + resource.Trim().TrimStart(StringSplits.ForwardSlash));
         }

        /// <summary>
        /// Конструктор и инициализатор нашей обертки 
        /// </summary>
        /// <param name="_user">Имя пользователя (адрес электронной почты)</param>
        /// <param name="_password">Пароль пользователя</param>
        /// <param name="_uri">Базовый URL api Рокет Чат</param>
        /// <exception cref="TypeInitializationException"></exception>
        public RocketChat(string _user, string _password, string _uri)
        {
            user = _user;
            password = _password;
            BaseUrl = _uri;
            authenthicated = false;


            if (BaseUrl.IsNullOrEmpty())
                throw new TypeInitializationException("RocketChat", new ApplicationException("BaseUrl is required"));

            BaseUrl = _uri.NormalizeHostOrFQDN();
            RocketChatLogin();
        }




        /// <summary>
        /// Получение id пользователя и токена Рокет Чат 
        /// </summary>
        /// <exception cref="ApplicationException"></exception>
        private void  RocketChatLogin ()
        {
            string resource = "login";
            RestClient client = new RestClient(BaseUrl);
            RestRequest request = new RestRequest(resource, Method.Post);
            request.AddHeader("Accept", @"application/json");

            var body = new
            {
                user = user,
                password = password
            };
            request.AddJsonBody(body);

            string content = client.Execute(request).Content;


            LoginResponse.Root response = JsonConvert.DeserializeObject<LoginResponse.Root>(content);

            if (response.Status != "success")
            {
                //Console.WriteLine("Ошибка авторизации"); /// тут нужно поменять на интерфейс логирования 
                throw new ApplicationException("Auth error ");
            }


            userId = response.Data.UserId;
            authToken = response.Data.AuthToken;
            authenthicated = true;


        }


    }
}
