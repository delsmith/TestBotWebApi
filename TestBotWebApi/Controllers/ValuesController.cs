using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Threading.Tasks;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace TestBotWebApi.Controllers
{
    /*
    // POST: Movies/Edit/5
    // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
    // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(int id, [Bind("ID,Title,ReleaseDate,Genre,Price")] Movie movie)
    {
        if (id != movie.ID)
        {
            return NotFound();
        }

        if (ModelState.IsValid)
        {
            try
            {
                _context.Update(movie);
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MovieExists(movie.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return RedirectToAction("Index");
        }
        return View(movie);
    }

        // POST api/values
        [HttpPost]
        public void Post(int id, [Bind()])
        {
            var content = Request.Content;
            string jsonContent = content.ReadAsStringAsync().Result;

            Console.WriteLine("PUT: {0}", jsonContent.ToString());
            data[0] = value;
            return;
        }

     */

    public class ValuesController : ApiController
    {
        static string[] data = { "value 0", "Word 1", "Bool: true", "hello world" };
        // GET api/values
        public IEnumerable<string> Get()
        {
            return data;
        }

        // GET api/values/2
        public string Get(int id)
        {
            if (id < 0 || id >= data.Length) return "Range error";
            else return data[id];
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
            var content = Request.Content;
            string jsonContent = content.ReadAsStringAsync().Result;

            Console.WriteLine("PUT: {0}", jsonContent.ToString());
            data[0] = value;
            return;
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
