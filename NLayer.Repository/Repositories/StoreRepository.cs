using Microsoft.EntityFrameworkCore;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Repositories
{
    public class StoreRepository : GenericRepository<Store>, IStoreRepository
    {
        public StoreRepository(AppDbContext context) : base(context)
        {
        }


        public async Task<Store> GetSingleStoreByIdWithProductsAsync(int storeId)
        {
            return await _context.Store.Include(x => x.Products).Where(x => x.Id == storeId).SingleOrDefaultAsync();
            //Sql join'i ef core ile yapılacak. Hint : Include
            throw new NotImplementedException();
        }

        
    }
}
