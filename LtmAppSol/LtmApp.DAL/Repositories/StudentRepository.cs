using LtmApp.DAL.Context;
using LtmApp.DAL.Core;
using LtmApp.DAL.Entities;
using LtmApp.DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Linq;
using LtmApp.DAL.Exceptions;

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

        public override Student GetEntity(int id)
        {
            var student = _ltmContext.Students.FirstOrDefault(cd => cd.ID == id && !cd.Deleted);
            return student;
        }

        public override void Remove(Student entity)
        {
            // Logica

            base.Remove(entity);
            base.SaveChanges();
        }

        public override void Update(Student entity)
        {
            // Logica

            if (string.IsNullOrEmpty(entity.FirstName))
            {
                throw new StudentException("El nombre es requerido");
            }

            base.Update(entity);
            base.SaveChanges();
        }

        public override void Save(Student entity)
        {
            // Logica

            if(string.IsNullOrEmpty(entity.FirstName))
            {
                throw new StudentException("El nombre es requerido");
            }

            base.Save(entity);
            base.SaveChanges();
        }
    }
}
