using System.Collections.Generic;

namespace LtmApp.Web.Models.Responses
{
    public class StudentDetailResponse
    {
        public bool success { get; set; }
        public StudentModel data { get; set; }
        public string message { get; set; }
    }
}
