using System.Collections.Generic;

namespace LtmApp.Web.Models.Responses
{
    public class CourseListResponse
    {
        public bool Success { get; set; }
        public List<CourseModel> data { get; set; }

        public string Message { get; set; }


    }
}
