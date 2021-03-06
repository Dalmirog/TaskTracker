﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskTracker.Controllers.Repositories;
using TaskTracker.Models;

namespace TaskTracker.Controllers
{
    public class TagsController : ApiController
    {
        private readonly TagsRepository repository = new TagsRepository();

        // GET: api/Tags
        public List<Tag> Get()
        {
            return repository.GetAll();
        }

        // GET: api/Tags/5
        public Tag Get(int id)
        {
            return repository.Find(id);
        }

        // POST: api/Tags
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tags/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tags/5
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                repository.Remove(id);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.Conflict);
            }

            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}