using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SindCoAPI.Data;

namespace SindCoAPI.Controllers
{
    public class ApartmentsController : ApiController
    {
        SindcoDbContext sindcoDbContext = new SindcoDbContext();

        // GET: api/Apartments
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Apartments/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Apartments
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Apartments/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Apartments/5
        public void Delete(int id)
        {
        }
    }
}
