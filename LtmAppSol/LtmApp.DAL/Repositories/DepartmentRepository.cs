
using LtmApp.DAL.Context;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using LtmApp.DAL.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace LtmApp.DAL.Repositories
{
    public class DepartmentRepository : IDepartmentRepository
    {
        private readonly LtmContext _LtmContext;
        private readonly ILogger<DepartmentRepository> _logger;
        public DepartmentRepository(LtmContext LtmContext, ILogger<DepartmentRepository> logger)
        {
            _LtmContext = LtmContext;
            _logger = logger;
        }
        public bool Exists(string Name)
        {
            return _LtmContext.Department.Any(cd => cd.Name == Name);
        }

        public List<DepartmentModel> GetAll()
        {
            var departments = _LtmContext.Department.Select(cd => new DepartmentModel()
            {
                Budget = cd.Budget,
                DepartmentID = cd.DepartmentID,
                Name = cd.Name,
                StartDate = cd.StartDate
            }).ToList();
            return departments;
        }

        public Department GetById(int idDepartment)
        {
            return _LtmContext.Department.Find(idDepartment);
        }

        public void Remove(Department department)
        {
            try
            {
                Department departmentToRemove = GetById(department.DepartmentID);
                departmentToRemove.DeletedDate = DateTime.Now;
                departmentToRemove.Deleted = true;
                departmentToRemove.UserDeleted = department.UserDeleted;
                _LtmContext.Department.Remove(departmentToRemove);
                _LtmContext.SaveChanges();
            }
            catch (Exception ex)
            {

                _logger.LogError($"Error Removiendo Departamento {ex.Message}", ex.ToString());
            }
        }

        public void Save(Department department)
        {
            try
            {
                Department departmentToAdd = new Department()
                {
                    CreationUser = department.CreationUser,
                    CreationDate = DateTime.Now,
                    Budget = department.Budget,
                    Administrator = department.Administrator,
                    Name = department.Name,
                    StartDate = department.StartDate
                };
                _LtmContext.Department.Add(departmentToAdd);
                _LtmContext.SaveChanges();
            }
            catch (Exception ex)
            {
                _logger.LogError($"Error Guardando Departamento {ex.Message}", ex.ToString());
            }
        }

        public void Update(Department department)
        {
            try
            {
                Department departmentToUpdate = GetById(department.DepartmentID);
                departmentToUpdate.DepartmentID = department.DepartmentID;
                departmentToUpdate.Name = department.Name;
                departmentToUpdate.StartDate = department.StartDate;
                departmentToUpdate.Budget = department.Budget;
                departmentToUpdate.Administrator = department.Administrator;
                departmentToUpdate.ModifyDate = DateTime.Now;
                departmentToUpdate.UserMod = department.UserMod;
                _LtmContext.Department.Update(departmentToUpdate);
                _LtmContext.SaveChanges();

            }
            catch (Exception ex)
            {

                _logger.LogError($"Error Actualizando Departamento {ex.Message}", ex.ToString());
            }
        }
    }
}
