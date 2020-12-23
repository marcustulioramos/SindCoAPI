using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SindCoAPI.Models;

namespace SindCoAPI.Controllers
{
    public class ComplexesController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Complex
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Complex/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Complex
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Complex/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Complex/5
        public void Delete(int id)
        {
        }
    }
}
