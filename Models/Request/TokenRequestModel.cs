namespace ptm_store_service.Models.Request
{
    public class TokenRequestModel
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public int UserId { get; set; }
    }
}
