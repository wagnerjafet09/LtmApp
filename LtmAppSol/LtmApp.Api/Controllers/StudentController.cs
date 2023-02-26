using LtmApp.DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using LtmApp.DAL.Models;
using LtmApp.DAL.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LtmApp.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepository _studentRepository;

        public StudentController(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        // GET: api/<StudentController>
        [HttpGet]
        public IActionResult Get()
        {
            var students = _studentRepository.GetEntities();
            return Ok(students);
        }

        // GET api/<StudentController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var student = _studentRepository.GetEntity(id);

            return Ok(student);
        }

        // POST api/<StudentController>
        [HttpPost("SaveStudent")]
        public IActionResult Post([FromBody] Student student)
        {
            _studentRepository.Save(student);

            return Ok();
        }

        // PUT api/<StudentController>/5
        [HttpPut("UpdateStudent")]
        public IActionResult Put([FromBody] Student student)
        {
            _studentRepository.Update(student);

            return Ok();
        }

        // DELETE api/<StudentController>/5
        [HttpDelete("RemoveStudent")]
        public IActionResult Delete([FromBody] Student student)
        {
            _studentRepository.Remove(student);

            return Ok();
        }
    }
}
