using LtmApp.DAL.Context;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Exceptions;
using LtmApp.DAL.Interfaces;
using LtmApp.DAL.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LtmApp.DAL.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly LtmContext _ltmContext;
        private readonly ILogger _logger;

        public StudentRepository(LtmContext ltmContext, ILogger<StudentRepository> logger)
        {
            _ltmContext = ltmContext;
            _logger = logger;
        }


        public bool Exists(int ID)
        {
            return _ltmContext.Students.Any(cd => cd.ID == ID);
        }

        public List<StudentModel> GetAll()
        {

            var students = _ltmContext.Students.Where(cd => !cd.Deleted).Select(cd => new StudentModel()
            {
                ID = cd.ID,
                FirstName = cd.FirstName,
                LastName = cd.LastName,
                EnrollmentDate = cd.EnrollmentDate,
                CreationDate = cd.CreationDate
            }
            ).ToList();

            return students;
        }

        public Student GetById(int ID)
        {
            return _ltmContext.Students.Find(ID);
        }

        public void Remove(Student student)
        {
            try
            {
                Student studentToRemove = GetById(student.ID);
                studentToRemove.ID = student.ID;
                studentToRemove.DeletedDate = DateTime.Now;
                studentToRemove.Deleted = true;
                studentToRemove.UserDeleted = student.UserDeleted;

                _ltmContext.Students.Remove(studentToRemove); 
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error removiendo el estudiante {ex.Message}", ex.ToString());
            }
        }

        public void Save(Student student)
        {
            try
            {
                Student studentToSave = new Student()
                {
                    Deleted = false,
                    CreationUser = student.CreationUser,
                    CreationDate = DateTime.Now,
                    LastName = student.LastName,
                    FirstName = student.FirstName,
                    EnrollmentDate = student.EnrollmentDate
                };

                _ltmContext.Students.Add(studentToSave);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error guardando el estudiante {ex.Message}", ex.ToString());
            }
        }

        public void Update(Student student)
        {
            try
            {
                Student studentToUpdate = GetById(student.ID);

                studentToUpdate.ID = student.ID;
                studentToUpdate.FirstName = student.FirstName;
                studentToUpdate.LastName = student.LastName;
                studentToUpdate.EnrollmentDate = student.EnrollmentDate;
                studentToUpdate.ModifyDate = DateTime.Now;
                studentToUpdate.UserMod = student.UserMod;

                _ltmContext.Students.Update(studentToUpdate);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error removiendo el estudiante {ex.Message}", ex.ToString());
            }
        }
    }
}
