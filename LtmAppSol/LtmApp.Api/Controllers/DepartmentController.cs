using LtmApp.BL.Contract;
using LtmApp.BL.Dtos;
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
        private readonly IDepartmentService departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            this.departmentService = departmentService;
        }
        // GET: api/<DepartmentController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = departmentService.GetAll();
            if (!result.Success) 
            {
                return BadRequest(result);
            }
            return Ok(result);
        }

        // GET api/<DepartmentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = departmentService.GetById(id);
            return Ok(result);
        }

        // POST api/<DepartmentController>
        [HttpPost("SaveDepartment")]
        public IActionResult Post([FromBody] DepartmentAddDto department)
        {
            var result = this.departmentService.SaveDepartment(department);
            return Ok(result);
            
        }

        // PUT api/<DepartmentController>
        [HttpPut("UpdateDepartment")]
        public IActionResult Put([FromBody] DepartmentUpdateDto department)
        {
            var result = this.departmentService.UpdateDepartment(department);
            return Ok(result);
        }

        // DELETE api/<DepartmentController>/5
        [HttpDelete("RemoveDepartment")]
        public IActionResult Remove([FromBody] DepartmentRemoveDto department)
        {
            var result = this.departmentService.RemoveDepartment(department);
            return Ok(result);
        }
    }
}
