using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Newtonsoft.Json;
using FacebookApp.Models;
using System.Threading.Tasks;

namespace BiApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public async Task<ActionResult> Index()
        {
            var me = new MeModel();
            var mepost = new PostModel();

            var accessToken = "EAAHr4yX3ZCVYBANF2pNKAPsW4reqAFjBbopeHhtRLaMQwevCyjz7WhhcZCm3FUPf6DEAj51FCotUpocdAwXYmI4wyRA0ToEOuGh2fpZA1VN4pVODRYMOOrASlHqBvykBLzyOkf3lK84rS0wtwCNLUh0cp784sPJxrZCYJiINnsdLgcPV9sKFvvpbczfD80HchJLmdDcJnb3IZC57IIUz7UtWZBTGo1LRiltx8p3KzkTWSd6f4cE8qg";
            var client = new HttpClient();
            var meResponse = await client.GetAsync($"https://graph.facebook.com/me?fields=id,name&access_token={accessToken}");
            var response = await meResponse.Content.ReadAsStringAsync();
            var responseModel = JsonConvert.DeserializeObject<MeModel>(response);
            me.Id = responseModel.Id;
            me.Name = responseModel.Name;
            me.AccessToken = accessToken;

            var mespost = await client.GetAsync($"https://graph.facebook.com/{me.Id}/accounts?&access_token={accessToken}");
            var mePostResponse = await mespost.Content.ReadAsStringAsync();
            var responsPostModel = JsonConvert.DeserializeObject<MeModel>(mePostResponse);
            me.data = responsPostModel.data;
            return View(me);
        }
    }
}