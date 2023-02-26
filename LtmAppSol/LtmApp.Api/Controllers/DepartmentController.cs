using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using LtmApp.DAL.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LtmApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentRepository _departmentRepository;
        public DepartmentController(IDepartmentRepository departmentRepository)
        {
            _departmentRepository = departmentRepository;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public IActionResult Get()
        {
            var deparments = _departmentRepository.GetEntities();
            return Ok(deparments);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var deparment = _departmentRepository.GetEntity(id);
            return Ok(deparment);
        }

        // POST api/<DepartmentController>
        [HttpPost("SaveDepartment")]
        public IActionResult Post([FromBody] Department department)
        {
            _departmentRepository.Save(department);
            return Ok();
        }

        // PUT api/<DepartmentController>
        [HttpPut("UpdateDeparment")]
        public IActionResult Put([FromBody] Department department)
        {
            _departmentRepository.Update(department);
            return Ok();
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("RemoveDepartment")]
        public IActionResult Remove([FromBody] Department department)
        {
            _departmentRepository.Remove(department);
            return Ok();
        }
    }
}
