using System.Collections.Generic;

namespace LtmApp.Web.Models.Responses
{
    public class StudentListResponse
    {
        public bool success { get; set; }
        public List<StudentModel> data { get; set; }
        public string message { get; set; }
    }
}
