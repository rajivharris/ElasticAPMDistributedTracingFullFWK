using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication2.Controllers
{
    public class HomeController : ApiController
    {
        private HttpClient client = new HttpClient();
        // GET api/<controller>
        public async Task<IEnumerable<string>> Get()
        {
            var res1 = await client.GetAsync("http://localhost:60498/");
            var res2 = await client.GetAsync("http://localhost:60531/");
            return new string[] { "value1", "value2" };
        }
    }
}