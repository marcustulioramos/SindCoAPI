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

    public class BuildingsController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Complex
        [CacheOutput(ClientTimeSpan = 60)]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var buildings = sindcoDbContext.Buildings;
            if (buildings == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(buildings);
        }

        // GET: api/Complex/5
        [CacheOutput(ClientTimeSpan = 60)]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var building = sindcoDbContext.Buildings.Find(id);
            if (building == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(building);
        }

        // POST: api/Complex
        [HttpPost]
        public IHttpActionResult Post([FromBody] Building building)
        {
            sindcoDbContext.Buildings.Add(building);
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The building was created successfully.");
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
                return BadRequest("The building was not created.");
            }
        }

        // PUT: api/Complex/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Building building)
        {
            var entity = sindcoDbContext.Buildings.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return BadRequest("No record found.");
            }

            entity.Name = building.Name;
            entity.Status = building.Status;
            entity.StatusById = building.StatusById;
            entity.StatusDate = building.StatusDate;
            entity.AddressLine1 = building.AddressLine1;
            entity.AddressLine2 = building.AddressLine2;
            entity.City = building.City;
            entity.County = building.County;
            entity.Country = building.Country;
            entity.PostCode = building.PostCode;
            entity.BlockId = building.BlockId;

            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The building was edited successfully.");
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
                return BadRequest("The building was not edited.");
            }
        }

        // DELETE: api/Complex/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var building = sindcoDbContext.Buildings.Find(id);
            if (building == null)
            {
                return BadRequest("No record found.");
            }
            sindcoDbContext.Buildings.Remove(building);
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The building was deleted successfully.");
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
                return BadRequest("The building was not deleted.");
            }
        }
    }
}
