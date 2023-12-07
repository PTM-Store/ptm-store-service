namespace ptm_store_service.Models.Response
{
    public class AddressesResponseModel
    {
        public int Id { get; set; }

        public string Street { get; set; }

        public string Ward { get; set; }

        public string City { get; set; }

        public string Province { get; set; }

        public int? UserId { get; set; }
    }
}
