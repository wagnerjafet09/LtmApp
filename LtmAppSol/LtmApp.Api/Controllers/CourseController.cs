using LtmApp.BL.Contract;
using LtmApp.BL.Dto.Course;
using LtmApp.BL.Service;
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
        private readonly ICourseService courseService;

        public CourseController(ICourseService courseService)

        {
            this.courseService = courseService;
        }
        // GET: api/<CourseController>
        [HttpGet]
        public IActionResult Get()
        {
            var result = this.courseService.GetAll();

            if (!result.Success) 
            {
                return BadRequest(result);
            }
            return Ok(result); 
        }

        // GET api/<CourseController>/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var result = courseService.GetById(id);
            return Ok(result);
        }

        // POST api/<CourseController>
        [HttpPost("SaveCourse")]
        public IActionResult Post([FromBody] CourseSaveDto course)
        {
            var result = courseService.SaveCourse(course);
            return Ok(result);
        }

        // PUT api/<CourseController>/5
        [HttpPut("UpdateCourse")]
        public IActionResult Put([FromBody] CourseUpdateDto course)
        {
            var result = courseService.UpdateCourse(course);
            return Ok(result);
        }

        // DELETE api/<CourseController>/5
        [HttpDelete("RemoveCourse")]
        public IActionResult Remove([FromBody] CourseRemoveDto course)
        {
            var result = courseService.RemoveCourse(course);
            return Ok(result);
        }
    }
}
