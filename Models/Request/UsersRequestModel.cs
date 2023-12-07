namespace ptm_store_service.Models.Request
{
    public class UsersRequestModel
    {
        public int Id { get; set; }

        public string ClientName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
    }
}
