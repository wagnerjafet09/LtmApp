using LtmApp.BL.Contract;
using LtmApp.BL.Core;
using LtmApp.BL.Dtos.Student;
using LtmApp.BL.Models;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;

using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace LtmApp.BL.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository studentRepository;
        private readonly ILogger<StudentService> logger;

        public StudentService(IStudentRepository studentRepository, ILogger<StudentService>logger)
        {
            this.studentRepository = studentRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var student = this.studentRepository.GetEntities().Select(cd => new StudentResultModel()
                {
                    CreationDate = cd.CreationDate,
                    EnrollmentDate = cd.EnrollmentDate.Value,
                    FirstName = cd.FirstName, 
                    LastName = cd.LastName,
                    StudentId = cd.ID
                }).ToList();

                result.Data = student;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error obteniendo a los estudiantes";
                result.Success = false;
                this.logger.LogError($" { result.Message } ", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                var student = this.studentRepository.GetEntity(id);
                    
                StudentResultModel studentResultModel = new StudentResultModel()
                {
                    CreationDate = student.CreationDate,
                    EnrollmentDate = student.EnrollmentDate.Value,
                    FirstName = student.FirstName,
                    LastName = student.LastName,
                    StudentId = student.ID
                };
                result.Data = student;
                result.Success = true;
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error obteniendo el estudiante";
                result.Success = false;
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveStudent(StudentRemoveDto removeDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Student studentToRemove = this.studentRepository.GetEntity(removeDto.StudentId);

                studentToRemove.Deleted = removeDto.Deleted;
                studentToRemove.DeletedDate = removeDto.DeletedDate;
                studentToRemove.UserDeleted = removeDto.UserDeleted;

                this.studentRepository.Update(studentToRemove);

                result.Success = true;
                result.Message = "Estudiante eliminado correctamente";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error removiendo el estudiante";
                this.logger.LogError($" { result.Message } ", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveStudent(StudentSaveDto saveDto)
        {
            ServiceResult result = new ServiceResult();

            try
            {
                Student student = new Student()
                {
                    CreationDate = saveDto.CreationDate,
                    CreationUser = saveDto.CreationUser,
                    FirstName = saveDto.FirstName, 
                    LastName = saveDto.LastName,
                    EnrollmentDate = saveDto.EnrollmentDate
                };

                this.studentRepository.Save(student);

                result.Success = true;
                result.Message = "Estudiante agregado correctamente";
            }
            catch (Exception ex)
            {
                result.Message = "Ocurrio un error agregando el estudiante";
                result.Success = false;
                this.logger.LogError($" { result.Message } ", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateStudent(StudentUpdateDto updateDto)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Student studentToUpdate = this.studentRepository.GetEntity(updateDto.StudentId);

                studentToUpdate.ModifyDate = updateDto.ModifyDate;
                studentToUpdate.UserMod = updateDto.UserMod;
                studentToUpdate.FirstName = updateDto.FirstName;
                studentToUpdate.LastName = updateDto.LastName;
                studentToUpdate.EnrollmentDate = updateDto.EnrollmentDate;

                this.studentRepository.Update(studentToUpdate);

                result.Success = true;
                result.Message = "Estudiante actualizado correctamente";
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Ocurrio un error actualizando el estudiante";
                this.logger.LogError($" {result.Message} ", ex.ToString());
            }
            return result;
        }
    }
}
