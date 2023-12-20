namespace ptm_store_service.Models.Request
{
    public class VariantsRequestModel
    {
        public string Name { get; set; }

        public string SkuCode { get; set; }

        public double Price { get; set; }

        public double SalePrice { get; set; }

        public string Image { get; set; }

        public int? ProductId { get; set; }
    }
}
