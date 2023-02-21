using LtmApp.DAL.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace LtmApp.DAL.Entities
{
    public class Instructor : Person
    {
        public int Id { get; set; }
        public DateTime? HireDate { get; set; }

    }
}
