namespace LtmApp.Web.Models.Responses
{
    public class CommandResponse
    {
        public bool success { get; set; }
        public string message { get; set; }
        public dynamic data { get; set; }

    }
}
