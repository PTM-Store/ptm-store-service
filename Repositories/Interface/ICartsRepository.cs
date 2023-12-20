using ptm_store_service.Data;

namespace ptm_store_service.Repositories.Interface
{
    public interface ICartsRepository
    {
        void CreateCart(Carts cart);
    }
}
