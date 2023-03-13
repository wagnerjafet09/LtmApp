using LtmApp.BL.Contract;
using LtmApp.BL.Core;
using LtmApp.BL.Dto.Course;
using LtmApp.BL.Models;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using LtmApp.DAL.Repositories;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LtmApp.BL.Service
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository courseRepository;

        public CourseService(ICourseRepository courseRepository, ILogger<CourseService>logger) 
        {
            this.courseRepository = courseRepository;
            this.logger = logger;
        }

        public ILogger<CourseService> logger { get; }

        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();

            try
            {
                this.logger.LogInformation("Consultando los cursos");
                var courses = this.courseRepository.GetEntities().Select(cd=>new CourseResultModel() 
                {
                    CreationDate = cd.CreationDate,
                    Title = cd.Title,
                    Credits = cd.Credits,
                    DepartmentID = cd.DepartmentID,
                    CourseID = cd.CourseID
                }).ToList();
                result.Data = courses;
                result.Success = true;
                this.logger.LogInformation("Se consultaron los cursos");
                result.Message = "Los Cursos fueron obtenidos Exitosamente";

            }
            catch (Exception ex)
            {

                result.Message = "Ocurrio un error obteniendo los cursos";
                result.Success= false;
                this.logger.LogError($" {result.Message} ",ex.ToString());
            }
            return result; 
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var course = this.courseRepository.GetEntity(id);

                CourseResultModel courseResultModel = new CourseResultModel()
                {
                    CreationDate = course.CreationDate,
                    Title = course.Title,
                    Credits = course.Credits,
                    DepartmentID = course.DepartmentID,
                    CourseID = course.CourseID
                };

                result.Success = true;
                result.Data = courseResultModel;
                result.Message = "El Curso fue obtenido Exitosamente";
            }
            catch (Exception ex)
            {

                result.Message = "Ocurrio un error obteniendo el curso";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveCourse(CourseRemoveDto removeDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Course courseToRemove = this.courseRepository.GetEntity(removeDto.CourseID);
                courseToRemove.Deleted = removeDto.Deleted;
                courseToRemove.DeletedDate = removeDto.DeletedDate;
                courseToRemove.UserDeleted= removeDto.UserDeleted;

                this.courseRepository.remove(courseToRemove);
                result.Message = "El Curso fue eliminado Exitosamente";
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error obteniendo los cursos";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveCourse(CourseSaveDto saveDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Course course = new Course()
                {
                    Title = saveDto.Title,
                    Credits= saveDto.Credits,
                    DepartmentID=saveDto.DepartmentID,
                    CreationDate=saveDto.CreationDate,
                    CreationUser=saveDto.CreationUser
                };
                
                this.courseRepository.save(course);
                this.courseRepository.saveChanges();
                result.Message = "El Curso fue Guardado Exitosamente";
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Error Guardando el curso";
                result.Success = false;
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateCourse(CourseUpdateDto updateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Course course = new Course()
                {
                    CourseID = updateDto.CourseID,
                    Credits = updateDto.Credits,
                    Title = updateDto.Title,
                    DepartmentID = updateDto.DepartmentID,
                    ModifyDate = updateDto.ModifyDate,
                    UserMod = updateDto.UserMod
                };

                this.courseRepository.update(course);
                this.courseRepository.saveChanges();
                result.Message = "El Curso fue actualizado Exitosamente";
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Error Actualizando el curso";
                result.Success = false;
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }
    }
}
