using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Root myDeserializedClass = JsonConvert.DeserializeObject<Root>(myJsonResponse);

namespace RocketChatLib
{
  public class ChannelList { 
    public class Attachment
    {
        public DateTime ts { get; set; }
        public string title { get; set; }
        public string title_link { get; set; }
        public bool title_link_download { get; set; }
        public string type { get; set; }
    }

    public class Channel
    {
        public string _id { get; set; }
        public string fname { get; set; }
        public string description { get; set; }
        public bool broadcast { get; set; }
        public bool encrypted { get; set; }
        public bool teamMain { get; set; }
        public string name { get; set; }
        public string t { get; set; }
        public int msgs { get; set; }
        public int usersCount { get; set; }
        public U u { get; set; }
        public DateTime ts { get; set; }
        public bool ro { get; set; }
        public string teamId { get; set; }
        public bool @default { get; set; }
        public bool sysMes { get; set; }
        public DateTime _updatedAt { get; set; }
        public CustomFields customFields { get; set; }
        public LastMessage lastMessage { get; set; }
        public DateTime? lm { get; set; }
        public string topic { get; set; }
        public string announcement { get; set; }
        public string avatarETag { get; set; }
        public string avatarOrigin { get; set; }
        public bool? featured { get; set; }
        public bool? favorite { get; set; }
    }

    public class CustomFields
    {
    }

    public class File
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class File2
    {
        public string _id { get; set; }
        public string name { get; set; }
        public string type { get; set; }
    }

    public class LastMessage
    {
        public string _id { get; set; }
        public string rid { get; set; }
        public string msg { get; set; }
        public DateTime ts { get; set; }
        public U u { get; set; }
        public bool unread { get; set; }
        public DateTime _updatedAt { get; set; }
        public List<object> urls { get; set; }
        public List<object> mentions { get; set; }
        public List<object> channels { get; set; }
        public List<Md> md { get; set; }
        public File file { get; set; }
        public List<File> files { get; set; }
        public bool? groupable { get; set; }
        public List<Attachment> attachments { get; set; }
    }

    public class Md
    {
        public string type { get; set; }
        public List<Value> value { get; set; }
    }

    public class Root
    {
        public List<Channel> channels { get; set; }
        public int count { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
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
        public string value { get; set; }
    }

    }
}