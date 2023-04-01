using System;

namespace LtmApp.Web.Models.Requests
{
    public class DeparmentUpdateRequest
    {
        public int DepartmentID { get; set; }
        public string Name { get; set; }
        public double budget { get; set; }
        public DateTime StartDate { get; set; }
        public int Administrator { get; set; }
        public DateTime ModifyDate { get; set; }
        public int UserMod { get; set; }

    }
}
