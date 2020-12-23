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

    public class ComplexesController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Complex
        public IHttpActionResult Get()
        {
            var complexes = sindcoDbContext.Complexes;
            if (complexes == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(complexes);
        }

        // GET: api/Complex/5
        public IHttpActionResult Get(int id)
        {
            var complex = sindcoDbContext.Complexes.Find(id);
            if (complex == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(complex);
        }

        // POST: api/Complex
        public IHttpActionResult Post([FromBody]Complex complex)
        {
            sindcoDbContext.Complexes.Add(complex);
            sindcoDbContext.SaveChanges();
            return Ok("The complex was created successfully.");
        }

        // PUT: api/Complex/5
        public IHttpActionResult Put(int id, [FromBody] Complex complex)
        {
            var entity = sindcoDbContext.Complexes.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return BadRequest("No record found.");
            }
            entity.Name = complex.Name;
            entity.Status = complex.Status;
            sindcoDbContext.SaveChanges();
            return Ok("The complex was edited successfully.");

        }

        // DELETE: api/Complex/5
        public IHttpActionResult Delete(int id)
        {
            var complex = sindcoDbContext.Complexes.Find(id);
            if (complex == null)
            {
                return BadRequest("No record found.");
            }
            sindcoDbContext.Complexes.Remove(complex);
            sindcoDbContext.SaveChanges();
            return Ok("The complex was deleted successfully.");
        }
    }
}
