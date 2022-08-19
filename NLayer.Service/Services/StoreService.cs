using AutoMapper;
using NLayer.Core.DTOs;
using NLayer.Core.Repositories;
using NLayer.Core.Services;
using NLayer.Core.UnitOfWorks;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Store = NLayer.Core.Store;
using NLayer.Repository.Repositories;

namespace NLayer.Service.Services
{
    public class StoreService : Service<Store>, IStoreService
    {
        private readonly IStoreRepository _storeRepository;
        private readonly IMapper _mapper;

        public StoreService(IGenericRepository<Store> repository, IUnitOfWork unitOfWork, IMapper mapper, IStoreRepository storeRepository) : base(repository, unitOfWork)
        {
            _mapper = mapper;
            _storeRepository = storeRepository;
        }

      

        //public async Task<CustomResponseDto<StoreWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(int StoreId)
        //{
        //    var store = await _storeRepository.GetSingleStoreByIdWithProductsAsync(StoreId);

        //    var storeDto = _mapper.Map<StoreWithProductsDto>(store);

        //    return CustomResponseDto<StoreWithProductsDto>.Success(200, storeDto);
        //}

        public Task<CustomResponseDto<StoreWithProductsDto>> GetSingleStoreByIdWithProductsAsync(int StoreId)
        {
            throw new NotImplementedException();
        }

        
    }
}
