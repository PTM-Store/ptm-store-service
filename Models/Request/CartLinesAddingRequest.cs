namespace ptm_store_service.Models.Request
{
    public class CartLinesAddingRequest
    {
        public int Quantity { get; set; }

        public int? CartId { get; set; }

        public int? ProductId { get; set; }
    }
}
