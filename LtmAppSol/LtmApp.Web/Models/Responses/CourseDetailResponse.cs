using System.Collections.Generic;

namespace LtmApp.Web.Models.Responses
{
    public class CourseDetailResponse
    {
        public bool Success { get; set; }
        public CourseModel data { get; set; }
        public string Message { get; set; }

    }
}


