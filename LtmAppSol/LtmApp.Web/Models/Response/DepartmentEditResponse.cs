namespace LtmApp.Web.Models.Response
{
    public class DepartmentEditResponse
    {
        public bool success { get; set; }
        public DepartmentModel data { get; set; }
        public string message { get; set; }
    }
}
