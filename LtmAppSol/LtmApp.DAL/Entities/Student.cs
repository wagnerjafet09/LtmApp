using LtmApp.DAL.Core;
using System;
using System.ComponentModel.DataAnnotations;

namespace LtmApp.DAL.Entities
{
    public class Student : Person
    {
        [Key]
        public int ID { get; set; }
        public DateTime? EnrollmentDate { get; set; }
    }
}