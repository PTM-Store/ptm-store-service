using ptm_store_service.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface ICartLinesRepository
    {
        List<CartLines> GetAllCartLines();
        CartLines GetCartLinesById(int id);
        void CreateCartLine(CartLines cartLine);
        void UpdateCartLine(CartLines cartLine);
        void DeleteCartLine(CartLines cartLine);
    }
}
