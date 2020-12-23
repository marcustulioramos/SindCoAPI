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
    public class ApartmentsController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Apartments
        public IHttpActionResult Get()
        {
            var apartments = sindcoDbContext.Apartments;
            return Ok(apartments);
        }

        // GET: api/Apartments/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Apartments
        public IHttpActionResult Post([FromBody]string value)
        {
            return Ok();
        }

        // PUT: api/Apartments/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE: api/Apartments/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
