namespace ptm_store_service.Models.Response
{
    public class CartLinesResponseModel
    {
        public int Id { get; set; }

        public int Quantity { get; set; }

        public int? CartId { get; set; }

        public int? VariantId { get; set; }
    }
}
