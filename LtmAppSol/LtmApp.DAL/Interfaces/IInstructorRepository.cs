using LtmApp.DAL.Entities;
using LtmApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Interfaces
{
    public interface IInstructorRepository
    {
        List<InstructorModel> GetAll();

        void Save(Instructor instructor);

        void Update(Instructor instructor);

        void Remove(Instructor instructor);

        Instructor GetByID(int instructorID);

        bool Exists(int Id);
    }
}
