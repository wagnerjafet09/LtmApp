
using LtmApp.BL.Contract;
using LtmApp.BL.Core;
using LtmApp.BL.Dtos;
using LtmApp.BL.Models;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;

namespace LtmApp.BL.Services
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentRepository departmentRepository;
        private readonly ILogger<DepartmentService> logger;

        public DepartmentService(IDepartmentRepository departmentRepository, ILogger<DepartmentService> logger)
        {
            this.departmentRepository = departmentRepository;
            this.logger = logger;
        }
        public ServiceResult GetAll()
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.logger.LogInformation("Consultando Los Departamentos");
                var departments = this.departmentRepository.GetEntities().Select(dep => new DepartmentModel() 
                {
                    DepartmentID = dep.DepartmentID,
                    Budget = dep.Budget,
                    CreateDate = dep.CreationDate,
                    Name = dep.Name,
                    StartDate = dep.StartDate
                }).ToList();
                result.Data = departments;
                this.logger.LogInformation("Se Consultando Los Departamentos");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error Obteniendo los Departamento";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult GetById(int Id)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                this.logger.LogInformation("Consultando el Departamento");
                var department = this.departmentRepository.GetEntity(Id);
                DepartmentModel departmentModel = new DepartmentModel()
                {
                    DepartmentID = department.DepartmentID,
                    Budget = department.Budget,
                    CreateDate = department.CreationDate,
                    Name = department.Name,
                    StartDate = department.StartDate
                };
                result.Data= departmentModel;
                this.logger.LogInformation("Se Consultó el Departamento");
            }
            catch (Exception ex)
            {
                result.Success = false;
                result.Message = "Error Obteniendo el Departamento";
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult RemoveDepartment(DepartmentRemoveDto departmentRemove)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Department department = this.departmentRepository.GetEntity(departmentRemove.DepartmentId);
                department.DepartmentID = departmentRemove.DepartmentId;
                department.DeletedDate = departmentRemove.RemoveDate;
                department.Deleted = true;
                department.UserDeleted = departmentRemove.RemoveUser;


                this.departmentRepository.Update(department);
                this.departmentRepository.SaveChanges();
                result.Success = true;
                result.Message = "El Departamento fue Removido Exitosamente";

            }
            catch (Exception ex)
            {

                result.Message = "Error Removiendo el departamento";
                result.Success = false;
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult SaveDepartment(DepartmentAddDto departmentAdd)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Department department = new Department()
                {
                    Administrator = departmentAdd.Administrator,
                    Budget = departmentAdd.Budget,
                    CreationDate = departmentAdd.CreationDate,
                    CreationUser = departmentAdd.CreationUser,
                    Name = departmentAdd.Name,
                    StartDate = departmentAdd.StartDate

                };

                this.departmentRepository.Save(department);
                this.departmentRepository.SaveChanges();
                result.Message = "El Departamento fue Guardado Exitosamente";
                result.Success = true;


            }
            catch (Exception ex)
            {
                result.Message = "Error Guardando el departamento";
                result.Success = false;
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }

        public ServiceResult UpdateDepartment(DepartmentUpdateDto departmentUpdate)
        {
            ServiceResult result = new ServiceResult();
            try
            {
                Department department = this.departmentRepository.GetEntity(departmentUpdate.DepartmentId);
                department.DepartmentID = departmentUpdate.DepartmentId;
                department.Administrator = departmentUpdate.Administrator;
                department.Budget = departmentUpdate.Budget;
                department.ModifyDate = departmentUpdate.ModifyDate;
                department.UserMod = departmentUpdate.ModifyUser;
                department.Name = departmentUpdate.Name;
                department.StartDate = departmentUpdate.StartDate;

                this.departmentRepository.Update(department);
                this.departmentRepository.SaveChanges();
                result.Success = true;
                result.Message = "El Departamento fue Modificado Exitosamente";

            }
            catch (Exception ex)
            {
                result.Message = "Error Actualizando el departamento";
                result.Success = false;
                this.logger.LogError($"{result.Message}", ex.ToString());
            }
            return result;
        }
    }
}
