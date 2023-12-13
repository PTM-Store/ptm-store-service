namespace ptm_store_service.Models.Response
{
    public class ApiResponse
    {
        public bool Success { get; set; }
        public string Message { get; set; }
        public object Data {  get; set; }
    }
}
