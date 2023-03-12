
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
    public class DepartmentRepository : Core.RepositoryBase<Department>, IDepartmentRepository
    {
        private readonly LtmContext _LtmContext;
        private readonly ILogger<DepartmentRepository> _logger;
        public DepartmentRepository(LtmContext LtmContext, ILogger<DepartmentRepository> logger) : base(LtmContext)
        {
            _LtmContext = LtmContext;
            _logger = logger;
        }
        public override List<Department> GetEntities() 
        {
            var departments = _LtmContext.Department.Where(dep => !dep.Deleted).ToList();
            return departments;
        }
        public override void Update(Department entity) 
        { 
            base.SaveChanges();
        }
    }
}
