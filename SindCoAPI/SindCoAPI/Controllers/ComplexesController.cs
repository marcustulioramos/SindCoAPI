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
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The complex was created successfully.");
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
                return BadRequest("The complex was not created.");
            }
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
            entity.CreatedById = complex.CreatedById;
            entity.Status = complex.Status;
            entity.StatusById = complex.StatusById;
            entity.StatusDate = complex.StatusDate;
            entity.AddressLine1 = complex.AddressLine1;
            entity.AddressLine2 = complex.AddressLine2;
            entity.City = complex.City;
            entity.County = complex.County;
            entity.Country = complex.Country;
            entity.PostCode = complex.PostCode;
            entity.Telephone = complex.Telephone;
            entity.Email = complex.Email;
            try
            {
                sindcoDbContext.SaveChanges();
                return Ok("The complex was edited successfully.");
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
                return BadRequest("The complex was not edited.");
            }
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
            try
            {
                sindcoDbContext.SaveChanges();
            return Ok("The complex was deleted successfully.");
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
                return BadRequest("The complex was not deleted.");
            }
        }
    }
}
