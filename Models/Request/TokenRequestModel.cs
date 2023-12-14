namespace ptm_store_service.Models.Request
{
    public class TokenRequestModel
    {
        public int Id { get; set; }
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
        public string UserId { get; set; }
    }
}
