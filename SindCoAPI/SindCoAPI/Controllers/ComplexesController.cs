﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using SindCoAPI.Data;

namespace SindCoAPI.Controllers
{
    public class ComplexesController : ApiController
    {
        SindcoDbContext sindcoDbContext = new SindcoDbContext();

        // GET: api/Complexes
        public IHttpActionResult Get()
        {
            var complexes = sindcoDbContext.Complexes;
            return Ok(complexes);
        }

        // GET: api/Complexes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Complexes
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Complexes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Complexes/5
        public void Delete(int id)
        {
        }
    }
}
