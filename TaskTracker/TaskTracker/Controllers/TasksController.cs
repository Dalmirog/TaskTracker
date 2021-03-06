﻿using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TaskTracker.Controllers.Repositories;
using TaskTracker.Models;

namespace TaskTracker.Controllers
{
    public class TasksController : ApiController
    {
        private readonly TasksRepository repository = new TasksRepository(new ProjectsRepository(), new TagsRepository());

        // GET: api/Tasks
        public List<Task> Get()
        {
            return repository.GetAll();
        }

        // GET: api/Tasks/5
        public Task Get(int id)
        {
            return repository.Find(id);
        }

        // POST: api/Tasks
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Tasks/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Tasks/5
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