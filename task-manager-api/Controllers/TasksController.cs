using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using task_manager_api.Database;
using task_manager_api.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace task_manager_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        DatabaseContext _context;
        public TasksController(DatabaseContext Context)
        {
            _context = Context;
        }

        // GET: api/<TasksController>
        [HttpGet]
        public IEnumerable<Task> Get()
        {
            return _context.Tasks;
        }

        // GET api/<TasksController>/5
        [HttpGet("{id}")]
        public Task Get(int id)
        {
            return _context.Tasks.Find(id);
        }

        // POST api/<TasksController>
        [HttpPost]
        public IActionResult Post([FromBody] Task task)
        {
            try
            {
                _context.Tasks.Add(task);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status201Created);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // PUT api/<TasksController>/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Task task)
        {
            try
            {
                _context.Tasks.Update(task);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        // DELETE api/<TasksController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id, [FromBody] Task task)
        {
            try
            {
                _context.Tasks.Remove(task);
                _context.SaveChanges();
                return StatusCode(StatusCodes.Status200OK);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
