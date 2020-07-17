using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Models;
using EmployeeService.Repositories;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [Route("api/employees/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly EmployeeRepository repo;
        public EmployeeController(EmployeeRepository _repo)
        {
            repo = _repo;
        }
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
            Employees e = repo.getById(id);
            if(e == null)
            {
                return NotFound("Employee Not Found");
            }
            else
            {
                return Ok(e);
            }
        }

        // POST api/<EmployeeController>
        [Authorize]
        [HttpPost]
        public IActionResult Post(Employees e)
        {
            try
            {
                repo.addEmployee(e);
                return Ok("Employee Added Successfully");
            } catch (Exception ex)
            {
                return BadRequest("Cannot Add Employee");
            }
        }

        // PUT api/<EmployeeController>/5
        [Authorize]
        [HttpPut]
        //if HttpPut("{id}")  the "string id" should be the first parameter of response listener function
        //or else error!!
        public IActionResult Put(Employees e)
        {

            try
            {
                repo.updateEmployee(e);
                return Ok("Employee Updated Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        [Authorize]
        public IActionResult Delete(string id)
        {
            try
            {
                repo.deleteEmployee(id);
                return Ok("Employee Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
