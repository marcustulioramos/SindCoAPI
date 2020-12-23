using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SindCoAPI.Data;

namespace SindCoAPI.Controllers
{
    public class BuildingsController : ApiController
    {
        SindcoDbContext sindcoDbContext = new SindcoDbContext();

        // GET: api/Buildings
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Buildings/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Buildings
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Buildings/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Buildings/5
        public void Delete(int id)
        {
        }
    }
}
