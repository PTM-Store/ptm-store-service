namespace ptm_store_service.Models.Response
{
    public class VariantsResponseModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string SkuCode { get; set; }

        public double Price { get; set; }

        public double SalePrice { get; set; }

        public string Image { get; set; }

        public int? ProductId { get; set; }
    }
}
