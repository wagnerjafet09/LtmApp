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
    public class CourseRepository: Core.RepositoryBase<Course>, ICourseRepository
    {
        private readonly LtmContext _ltmContext;
        private readonly ILogger<CourseRepository> _illooger;

        public CourseRepository(LtmContext ltmContext, ILogger<CourseRepository> illooger): base(ltmContext)
        {
            _ltmContext = ltmContext;
            _illooger = illooger;
        }

        public override List<Course> GetEntities()
        {
            var course = this._ltmContext.Course.Where(crs=>!crs.Deleted).ToList();
            return course;
        }
    }
}
