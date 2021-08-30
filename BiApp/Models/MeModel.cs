using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FacebookApp.Models
{
    public class MeModel
    {
        public string AccessToken { get; set; }
        public string Name { get; set; }
        public string Id { get; set; }

        public List<AccountData> data { get; set; }

    }



    public class AccountData
    {
        public string access_token { get; set; }
        public string category { get; set; }
        public string name { get; set; }
        public string id { get; set; }

   }

   


}
