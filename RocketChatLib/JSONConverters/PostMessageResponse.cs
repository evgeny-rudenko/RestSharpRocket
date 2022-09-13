using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RocketChatLib
{
    public class PostMessageResponse
    {
        // Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);
        public class Md
        {
            public string type { get; set; }
            public List<Value> value { get; set; }
        }

        public class Message
        {
            public string alias { get; set; }
            public string msg { get; set; }
            public List<object> attachments { get; set; }
            public bool parseUrls { get; set; }
            public bool groupable { get; set; }
            public DateTime ts { get; set; }
            public U u { get; set; }
            public string rid { get; set; }
            public bool unread { get; set; }
            public string _id { get; set; }
            public DateTime _updatedAt { get; set; }
            public List<object> urls { get; set; }
            public List<object> mentions { get; set; }
            public List<object> channels { get; set; }
            public List<Md> md { get; set; }
        }

        public class Root
        {
            public long ts { get; set; }
            public string channel { get; set; }
            public Message message { get; set; }
            public bool success { get; set; }
        }

        public class U
        {
            public string _id { get; set; }
            public string username { get; set; }
            public string name { get; set; }
        }

        public class Value
        {
            public string type { get; set; }
            public object value { get; set; }
        }




    }
}