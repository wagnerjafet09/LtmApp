namespace LtmApp.Web.Models.Response
{
    public class DepartmentDetailResponse
    {
        public bool success { get; set; }
        public DepartmentModel data { get; set; }
        public string message { get; set; }
    }
}
