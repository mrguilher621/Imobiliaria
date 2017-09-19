using Imobiliaria.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Imobiliaria.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public async Task<ActionResult> Index()
        {

            var result = new DadosImobi();
            using (var client = new HttpClient())
            {
                client.BaseAddress =
                    new Uri("https://api.myjson.com/bins/obygl");

                var ret = await client.GetAsync("JSON3.json");

                if (ret.IsSuccessStatusCode)
                {
                    var str = ret.Content
                        .ReadAsStringAsync()
                        .Result;

                    result = JsonConvert
                    .DeserializeObject<DadosImobi>(str);
                }
            }
            return View(result);
        }
    }
}