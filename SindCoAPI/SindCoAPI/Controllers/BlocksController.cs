using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SindCoAPI.Models;
using WebApi.OutputCache.V2;

namespace SindCoAPI.Controllers
{
    [Authorize]
    public class BlocksController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Complex
        [CacheOutput(ClientTimeSpan = 60)]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var blocks = sindcoDbContext.Blocks;
            if (blocks == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(blocks);
        }

        // GET: api/Complex/5
        [CacheOutput(ClientTimeSpan = 60)]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var block = sindcoDbContext.Blocks.Find(id);
            if (block == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(block);
        }

        // POST: api/Complex
        [HttpPost]
        public IHttpActionResult Post([FromBody] Block block)
        {
            sindcoDbContext.Blocks.Add(block);
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The block was created successfully.");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
                return BadRequest("The block was not created.");
            }
        }

        // PUT: api/Complex/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Block block)
        {
            var entity = sindcoDbContext.Blocks.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return BadRequest("No record found.");
            }

            entity.Name = block.Name;
            entity.Status = block.Status;
            entity.StatusById = block.StatusById;
            entity.StatusDate = block.StatusDate;
            entity.ComplexId = block.ComplexId;

            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The block was edited successfully.");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
                return BadRequest("The block was not edited.");
            }
        }

        // DELETE: api/Complex/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var block = sindcoDbContext.Blocks.Find(id);
            if (block == null)
            {
                return BadRequest("No record found.");
            }
            sindcoDbContext.Blocks.Remove(block);
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The block was deleted successfully.");
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException ex)
            {
                foreach (var entityValidationErrors in ex.EntityValidationErrors)
                {
                    foreach (var validationError in entityValidationErrors.ValidationErrors)
                    {
                        System.Diagnostics.Debug.WriteLine("Property: " + validationError.PropertyName + " Error: " + validationError.ErrorMessage);
                    }
                }
                return BadRequest("The block was not deleted.");
            }
        }
    }
}
