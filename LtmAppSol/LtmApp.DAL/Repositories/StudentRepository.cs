using LtmApp.DAL.Context;
using LtmApp.DAL.Core;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;

namespace LtmApp.DAL.Repositories
{
    public class StudentRepository : RepositoryBase<Student>, IStudentRepository
    {
        private readonly LtmContext _ltmContext;
        private readonly ILogger _logger;

        public StudentRepository(LtmContext ltmContext, ILogger<StudentRepository> logger) : base(ltmContext)
        {
            _ltmContext = ltmContext;
            _logger = logger;
        }
        public override List<Student> GetEntities()
        {
            var students = _ltmContext.Students.Where(cd => !cd.Deleted).ToList();
            return students;
        }
    }
}
