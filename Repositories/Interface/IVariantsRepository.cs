using ptm_store_service.Data;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ptm_store_service.Repositories.Interface
{
    public interface IVariantsRepository
    {
        List<Variants> GetAllVariants();
        Variants GetVariantsById(int id);
        void CreateVariant(Variants variant);
        void DeleteVariant(Variants variant);
        void UpdateVariant(Variants variant);
    }
}
