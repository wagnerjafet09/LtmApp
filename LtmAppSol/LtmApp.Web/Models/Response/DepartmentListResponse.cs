using System.Collections.Generic;

namespace LtmApp.Web.Models.Response
{
    public class DepartmentListResponse
    {
        public bool success { get; set; }
        public List<DepartmentModel> data { get; set; }
        public string message { get; set; }
    }
}
