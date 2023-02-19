using LtmApp.DAL.Entities;
using LtmApp.DAL.Models;
using System.Collections.Generic;

namespace LtmApp.DAL.Interfaces
{
    public interface IStudentRepository
    {
        List<StudentModel> GetAll();
        void Save(Student student);
        void Update(Student student);
        void Remove(Student student);
        Student GetById(int ID);
        bool Exists(int ID);
    }
}
