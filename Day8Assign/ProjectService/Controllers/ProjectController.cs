﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectService.Models;
using ProjectService.Repositories;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ProjectService.Controllers
{
    [Route("api/projects")]
    [ApiController]
    public class ProjectController : ControllerBase
    {
        public static ProjectRepository repo = new ProjectRepository();
        // GET: api/<EmployeeController>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(repo.getAll());
        }

        // GET api/<EmployeeController>/5
        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            Projects e = repo.getById(id);
            if (e == null)
            {
                return NotFound("Employee Not Found");
            }
            else
            {
                return Ok(e);
            }
        }

        // POST api/<EmployeeController>
        [HttpPost]
        public IActionResult Post(Projects p)
        {
            try
            {
                repo.addProject(p);
                return Ok("Project Added Successfully");
            }
            catch (Exception e)
            {
                return BadRequest("Cannot Add Project");
            }
        }

        // PUT api/<EmployeeController>/5
        [HttpPut("{id}")]
        public IActionResult Put(Projects p)
        {

            try
            {
                repo.updateProject(p);
                return Ok("Project Updated Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest("Cannot Update Project");
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                repo.deleteProject(id);
                return Ok("Project Deleted Successfully");
            }
            catch (Exception e)
            {
                return BadRequest("Cannot Delete Project");
            }
        }
    }
}
