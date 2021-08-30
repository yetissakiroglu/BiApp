using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookApp.Models
{

    //Mesajlar
    public class MessageModel
    {
        public Message messages { get; set; }
    }

    public class Message
    {
        public List<MesajData> mesajdatas { get; set; }
    }

    public class MesajData
    {
        public string message { get; set; }
        public string id { get; set; }
    }



}
