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
    public class CourseController : ControllerBase
    {
        private readonly ICourseRepository _courseRepository;

        public CourseController(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public IActionResult Get()
        {
            var Course = _courseRepository.GetAll();
            return Ok(Course);
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var course = _courseRepository.GetById(id);
            return Ok(course);
        }

        // POST api/<CourseController>
        [HttpPost("SaveCourse")]
        public IActionResult Post([FromBody] Course course)
        {
            _courseRepository.Save(course);
            return Ok();
        }

        // PUT api/<CourseController>/5
        [HttpPut("UpdateCourse")]
        public IActionResult Put([FromBody] Course course)
        {
            _courseRepository.Update(course);
            return Ok();
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("RemoveCourse")]
        public IActionResult Remove([FromBody] Course course)
        {
            _courseRepository.Remove(course);
            return Ok();
        }
    }
}
