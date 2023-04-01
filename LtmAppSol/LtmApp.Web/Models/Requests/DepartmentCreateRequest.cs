using System;

namespace LtmApp.Web.Models.Requests
{
    public class DepartmentCreateRequest
    {
        public string Name { get; set; }
        public double budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
        public int CreationUser { get; set; }
        public DateTime CreationDate { get; set; }
    }
}
