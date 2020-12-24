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
    public class ApartmentsController : ApiController
    {
        ApplicationDbContext sindcoDbContext = new ApplicationDbContext();

        // GET: api/Complex
        [CacheOutput(ClientTimeSpan = 60)]
        [HttpGet]
        public IHttpActionResult Get()
        {
            var apartments = sindcoDbContext.Apartments;
            if (apartments == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(apartments);
        }

        // GET: api/Complex/5
        [CacheOutput(ClientTimeSpan = 60)]
        [HttpGet]
        public IHttpActionResult Get(int id)
        {
            var apartment = sindcoDbContext.Apartments.Find(id);
            if (apartment == null)
            {
                return BadRequest("No record found.");
            }
            return Ok(apartment);
        }

        // POST: api/Complex
        [HttpPost]
        public IHttpActionResult Post([FromBody] Apartment apartment)
        {
            sindcoDbContext.Apartments.Add(apartment);
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The apartment was created successfully.");
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
                return BadRequest("The apartment was not created.");
            }
        }

        // PUT: api/Complex/5
        [HttpPut]
        public IHttpActionResult Put(int id, [FromBody] Apartment apartment)
        {
            var entity = sindcoDbContext.Apartments.FirstOrDefault(x => x.Id == id);
            if (entity == null)
            {
                return BadRequest("No record found.");
            }

            entity.Number = apartment.Number;
            entity.Status = apartment.Status;
            entity.StatusById = apartment.StatusById;
            entity.StatusDate = apartment.StatusDate;
            entity.Floor = apartment.Floor;
            entity.Type = apartment.Type;
            entity.BuildingId = apartment.BuildingId;

            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The apartment was edited successfully.");
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
                return BadRequest("The apartment was not edited.");
            }
        }

        // DELETE: api/Complex/5
        [HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            var apartment = sindcoDbContext.Apartments.Find(id);
            if (apartment == null)
            {
                return BadRequest("No record found.");
            }
            sindcoDbContext.Apartments.Remove(apartment);
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The apartment was deleted successfully.");
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
                return BadRequest("The apartment was not deleted.");
            }
        }
    }
}
