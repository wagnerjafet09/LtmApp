using LtmApp.DAL.Entities;
using LtmApp.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Interfaces
{
    public interface IDepartmentRepository
    {
        List<DepartmentModel> GetAll();
        void Save(Department Department);
        void Update(Department Department);
        void Remove(Department Department);
        Department GetById(int idDepartment);
        bool Exists(string Name);
    }
}
