using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using EmployeeService.Models;
using EmployeeService.Repositories;
// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EmployeeService.Controllers
{
    [Route("api/employees/")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        public static EmployeeRepository repo = new EmployeeRepository();
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
        [HttpPut("{id}")]
        public IActionResult Put(Employees e)
        {

            try
            {
                repo.updateEmployee(e);
                return Ok("Employee Updated Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest("Cannot Update Employee");
            }
        }

        // DELETE api/<EmployeeController>/5
        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            try
            {
                repo.deleteEmployee(id);
                return Ok("Employee Deleted Successfully");
            }
            catch (Exception ex)
            {
                return BadRequest("Cannot Delete Employee");
            }
        }
    }
}
