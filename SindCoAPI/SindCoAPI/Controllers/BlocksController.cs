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
    public class BlocksController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Blocks
        public IHttpActionResult Get()
        {
            var blocks = sindcoDbContext.Blocks;
            return Ok(blocks);
        }

        // GET: api/Blocks/5
        public IHttpActionResult Get(int id)
        {
            return Ok();
        }

        // POST: api/Blocks
        public IHttpActionResult Post([FromBody]string value)
        {
            return Ok();
        }

        // PUT: api/Blocks/5
        public IHttpActionResult Put(int id, [FromBody]string value)
        {
            return Ok();
        }

        // DELETE: api/Blocks/5
        public IHttpActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
