using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestBotWebApi.Controllers
{
    public class TestbotController : ApiController
    {
        // GET: api/Testbot
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        //// GET: api/Testbot/5
        //public string Get(int id)
        //{
        //    return "value";
        //}

        // GET: api/Testbot/cmd
        public string Get(string id)
        {
            string cmd = id;
            return ($"command = '{cmd}'");
        }

        // POST: api/Testbot
        public async void Post(string id)
        {
            string cmd = id;
            var content = Request.Content;
            string jsonString = await content.ReadAsStringAsync();
            return;
        }

        // PUT: api/Testbot/5
        public async void Put(int id )
        {
            int x = id;
            var content = Request.Content;
            string jsonString = await content.ReadAsStringAsync();
            return;
        }

        // DELETE: api/Testbot/5
        public async void Delete(int id)
        {
            int x = id;
            var content = Request.Content;
            string jsonString = await content.ReadAsStringAsync();
            return;
        }
    }
}
