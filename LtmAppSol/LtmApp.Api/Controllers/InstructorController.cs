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
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorController(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }
        // GET: api/<InstructorController>
        [HttpGet("Obtener Todo")]
        public IEnumerable<InstructorModel> Get()
        {
            return _instructorRepository.GetAll();
        }

        // GET api/<InstructorController>/5
        [HttpGet("Obtener Por ID")]
        public IActionResult Get(int id)
        {
            var instructor = _instructorRepository.GetByID(id);
            return Ok(instructor);
        }

        // POST api/<InstructorController>
        [HttpPost("Guardar")]
        public IActionResult Post([FromBody] Instructor instructor)
        {
            _instructorRepository.Save(instructor);
            return Ok();
        }

        // PUT api/<InstructorController>/5
        [HttpPut("Actualizar")]
        public IActionResult Put([FromBody] Instructor instructor)
        {
            _instructorRepository.Update(instructor);
            return Ok();
        }

        // DELETE api/<InstructorController>/5
        [HttpDelete("Eliminar")]
        public IActionResult Remove([FromBody] Instructor instructor)
        {
            _instructorRepository.Remove(instructor);
            return Ok();
        }
    }
}
