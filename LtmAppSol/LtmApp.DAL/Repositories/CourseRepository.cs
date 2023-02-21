using LtmApp.DAL.Context;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using LtmApp.DAL.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using Microsoft.Extensions.Logging;

namespace LtmApp.DAL.Repositories
{
    public class CourseRepository: ICourseRepository
    {
        private readonly LtmContext _ltmContext;
        private readonly ILogger<CourseRepository> _illooger;

        public CourseRepository(LtmContext ltmContext, ILogger<CourseRepository> illooger)
        {
            _ltmContext = ltmContext;
            _illooger = illooger;
        }   


        public bool Exists(string title)
        {
            return _ltmContext.Course.Any(c => c.Title == title);
        }

        public List<CourseModel> GetAll()
        {

            var courses = _ltmContext.Course.Where(cd => !cd.Deleted).Select(cd => new CourseModel()
            {
                CourseID = cd.CourseID,
                Credits = cd.Credits,
                Title = cd.Title,
                CreationDate = cd.CreationDate,
                DepartmentID = cd.DepartmentID
            }).ToList();

            return courses;
        }

        public Course GetById(int ID)
        {
            return _ltmContext.Course.Find(ID);
        }

        public void Remove(Course course)
        {
            try
            {
                Course CourseToRemove = this.GetById(course.CourseID);
                CourseToRemove.DeletedDate = DateTime.Now;
                CourseToRemove.Deleted = true;
                CourseToRemove.UserDeleted = course.UserDeleted;
                CourseToRemove.CourseID = course.CourseID;
                

               _ltmContext.Course.Remove(CourseToRemove);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {

                _illooger.LogError($"Error removiendo el curso {ex.Message}", ex.ToString());
            }
        }

        public void Save(Course course)
        {
            try
            {
                Course CourseToSave = new Course();
                CourseToSave.CreationDate = DateTime.Now;
                CourseToSave.Title= course.Title;
                CourseToSave.Credits= course.Credits;
                CourseToSave.CreationUser = course.CreationUser;
                CourseToSave.DepartmentID = course.DepartmentID;

                _ltmContext.Course.Add(CourseToSave);
                _ltmContext.SaveChanges();

            }
            catch (Exception ex)
            {

                _illooger.LogError($"Eror guardando el curso {ex.Message}", ex.ToString());
            }
        }

        public void Update(Course course)
        {
            try
            {
                Course CourseToUpdate = this.GetById(course.CourseID);
                CourseToUpdate.Title = course.Title;
                CourseToUpdate.Credits = course.Credits;
                CourseToUpdate.ModifyDate = DateTime.Now;
                CourseToUpdate.DepartmentID = course.DepartmentID;
                CourseToUpdate.CourseID = course.CourseID;
                CourseToUpdate.UserMod = course.UserMod;

                _ltmContext.Course.Update(CourseToUpdate);
                _ltmContext.SaveChanges();
            }
            catch (Exception ex)
            {

                _illooger.LogError($"Eror actualizando el curso {ex.Message}", ex.ToString());
            }
        }
    }
}
