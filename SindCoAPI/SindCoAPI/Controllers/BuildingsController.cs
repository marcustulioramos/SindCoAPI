using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SindCoAPI.Models;

namespace SindCoAPI.Controllers
{
    [Authorize]

    public class BuildingsController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Buildings
        public IHttpActionResult Get()
        {
            var buildings = sindcoDbContext.Buildings;
            return Ok(buildings);
        }

        // GET: api/Buildings/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Buildings
        public IHttpActionResult Post([FromBody]string value)
        {
            return Ok();
        }

        // PUT: api/Buildings/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE: api/Buildings/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
