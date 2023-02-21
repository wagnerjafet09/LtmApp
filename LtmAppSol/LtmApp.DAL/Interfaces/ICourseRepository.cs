using LtmApp.DAL.Entities;
using LtmApp.DAL.Models;
using System.Collections.Generic;


namespace LtmApp.DAL.Interfaces
{
    public interface ICourseRepository
    {
        List<CourseModel> GetAll();

        void Save(Course course);

        void Update(Course course);

        void Remove(Course course);

        Course GetById(int ID);

        bool Exists(string title);

    }
}
