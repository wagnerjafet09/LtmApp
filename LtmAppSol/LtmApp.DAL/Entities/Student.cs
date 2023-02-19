using LtmApp.DAL.Core;
using System;

namespace LtmApp.DAL.Entities
{
    public class Student : Person
    {
        public int ID { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
}