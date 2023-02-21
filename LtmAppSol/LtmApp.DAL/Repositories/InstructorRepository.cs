using LtmApp.DAL.Context;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using LtmApp.DAL.Models;
using Microsoft.EntityFrameworkCore.Internal;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LtmApp.DAL.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly LtmContext _ltmContext;
        private readonly ILogger<InstructorModel> _logger;

        public InstructorRepository(LtmContext ltmContext, ILogger<InstructorModel> logger)
        {
            _ltmContext = ltmContext;
            _logger = logger;
        }
        public bool Exists(int Id)
        {
            return _ltmContext.Instructors.Any(cd => cd.Id == Id);
        }

        public List<InstructorModel> GetAll()
        {
            var instructors = _ltmContext.Instructors.Select(cd => new InstructorModel()
            {
                Id = cd.Id,
                FirstName = cd.FirstName,
                LastName = cd.LastName,
                HireDate = cd.HireDate
            }).ToList();

            return instructors;
        }

        public Instructor GetByID(int Id)
        {
            return _ltmContext.Instructors.Find(Id);
        }

        public void Remove(Instructor instructor)
        {
            try
            {
                Instructor InstructorToRemove = this.GetByID(instructor.Id);
                InstructorToRemove.Id = instructor.Id;

                _ltmContext.Instructors.Remove(InstructorToRemove);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError($"Error removiendo el Instructor {ex.Message}", ex.ToString());
            }
        }

        public void Save(Instructor instructor)
        {
            try
            {
                Instructor InstructorToAdd = new Instructor()
                {
                    FirstName = instructor.FirstName,
                    LastName = instructor.LastName,
                    HireDate = instructor.HireDate,
                };

                _ltmContext.Instructors.Add(InstructorToAdd);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError($"Eror guardando el Instructor {ex.Message}", ex.ToString());
            }
        }

        public void Update(Instructor instructor)
        {
            try
            {
                Instructor InstructorToUpdate = this.GetByID(instructor.Id);

                InstructorToUpdate.Id = instructor.Id;
                InstructorToUpdate.FirstName = instructor.FirstName;
                InstructorToUpdate.LastName = instructor.LastName;
                InstructorToUpdate.HireDate = instructor.HireDate;

                _ltmContext.Instructors.Update(InstructorToUpdate);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError($"Eror Actualizando el Instructor {ex.Message}", ex.ToString());
            }
        }
    }
}
