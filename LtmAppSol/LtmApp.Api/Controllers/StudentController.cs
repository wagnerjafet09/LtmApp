using LtmApp.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LtmApp.DAL.Models;
using LtmApp.DAL.Entities;
using LtmApp.BL.Contract;
using LtmApp.BL.Services;
using LtmApp.BL.Dtos.Student;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LtmApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = _studentService.GetAll();


            if (result.Success)
            {
                return Ok(result);
            }
            else 
            {
                return BadRequest(result);
            }
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = _studentService.GetById(id);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // POST api/<StudentController>
        [HttpPost("SaveStudent")]
        public IActionResult Post([FromBody] StudentSaveDto studentSaveDto)
        {
            var result = _studentService.SaveStudent(studentSaveDto);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // PUT api/<StudentController>/5
        [HttpPut("UpdateStudent")]
        public IActionResult Put([FromBody] StudentUpdateDto studentUpdateDto)
        {
            var result = _studentService.UpdateStudent(studentUpdateDto);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("RemoveStudent")]
        public IActionResult Delete([FromBody] StudentRemoveDto studentRemoveDto)
        {
            var result = _studentService.RemoveStudent(studentRemoveDto);

            if (result.Success)
            {
                return Ok(result);
            }
            else
            {
                return BadRequest(result);
            }
        }
    }
}
