using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Repositories
{
    public interface IStoreRepository : IGenericRepository<Store>
    {
        Task<Store> GetSingleStoreByIdWithProductsAsync(int StoreId);

        //Task<Store> GetSingleStoreByIdWithProductsAsync(int StoreId, int ProductId);

    }
}
