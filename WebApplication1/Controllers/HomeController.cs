using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace WebApplication1.Controllers
{
    public class HomeController : ApiController
    {
        private HttpClient client = new HttpClient();
        // GET api/<controller>
        public async Task<IEnumerable<string>> Get()
        {
            var res = await client.GetAsync("http://localhost:60457/");
            return new string[] { "value1", "value2" };
        }        
    }
}