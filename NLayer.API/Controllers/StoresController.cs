using Autofac.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.Core.DTOs;
using NLayer.Core.Services;
using NLayer.Service.Services;

namespace NLayer.API.Controllers
{
    public class StoresController : CustomBaseController
    {
        private readonly IStoreService _storeService;
        private readonly IMapper _mapper;
        public StoresController(IStoreService storeService, IMapper mapper)
        {
           _storeService = storeService;
            _mapper = mapper;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {

            var stores = await _storeService.GetAllAsync();

            var storesDto = _mapper.Map<List<StoreDto>>(stores.ToList());

            return CreateActionResult(CustomResponseDto<List<StoreDto>>.Success(200, storesDto));

        }


        // api/stores/GetSingleStoreByIdWithProducts/2
        [HttpGet("[action]/{storeId}")]
        public async Task<IActionResult> GetSingleStoreByIdWithProducts(int storeId)
        {

            return CreateActionResult(await _storeService.GetSingleStoreByIdWithProductsAsync(storeId));

        }

    }

}
