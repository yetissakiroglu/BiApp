using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookApp.Models
{

    public class PostModel
    {
        public string Id { get; set; }

        public Posts posts { get; set; }

    }


    public class Posts
    {
        public List<PostData> data { get; set; }
    }

    public class PostData
    {
        public string created_time { get; set; }
        public string message { get; set; }
        public string id { get; set; }
    }



}
