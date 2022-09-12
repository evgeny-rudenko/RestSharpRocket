using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestSharp;
using RocketChatLib;
using Newtonsoft.Json;
using System.IO;


namespace RestSharpRocket
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string uri = Properties.Settings.Default.uri;
            string suser = File.ReadAllText("user.txt");  
            string spassword = File.ReadAllText("password.txt");


            // Аутентификационные данные

            RocketChat r = new RocketChat(suser, spassword, uri);
            var channels = r.ChannelList;
            var response = r.PostMessage("Test", "servermessages");

            // Список каналов
            



        }
    }
}
