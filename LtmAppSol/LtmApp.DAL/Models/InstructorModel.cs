using LtmApp.DAL.Core;
using System;

namespace LtmApp.DAL.Models
{
    public class InstructorModel : PersonModel
    {
        public int Id { get; set; }
        public DateTime? HireDate { get; set; }
    }
}
