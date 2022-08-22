using Autofac.Core;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using NLayer.API.Filters;
using NLayer.Core;
using NLayer.Core.DTOs;
using NLayer.Core.Services;
using NLayer.Service.Services;

namespace NLayer.API.Controllers
{
    public class StoresController : CustomBaseController
    {
        private readonly IMapper _mapper;
        private readonly IStoreService _service;


        public StoresController(IMapper mapper, IStoreService storeService)
        {

            _mapper = mapper;
            _service = storeService;
        }


        //[HttpGet]
        //public async Task<IActionResult> GetAll()
        //{

        //    var stores = await _service.GetAllAsync();

        //    var storesDto = _mapper.Map<List<StoreDto>>(stores.ToList());

        //    return CreateActionResult(CustomResponseDto<List<StoreDto>>.Success(200, storesDto));

        //}

        /// GET api/products
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var stores = await _service.GetAllAsync();
            var storesDtos = _mapper.Map<List<StoreDto>>(stores.ToList());
            return CreateActionResult(CustomResponseDto<List<StoreDto>>.Success(200, storesDtos));
        }


        [ServiceFilter(typeof(NotFoundFilter<Store>))]
        ///GET /api/products/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {


            var store = await _service.GetByIdAsync(id);
            var storesDto = _mapper.Map<StoreDto>(store);
            return CreateActionResult(CustomResponseDto<StoreDto>.Success(200, storesDto));
        }



        [HttpPost]
        public async Task<IActionResult> Save(StoreDto storeDto)
        {
            var store = await _service.AddAsync(_mapper.Map<Store>(storeDto));
            var storesDto = _mapper.Map<StoreDto>(store);
            return CreateActionResult(CustomResponseDto<StoreDto>.Success(201, storesDto));
        }


        [HttpPut]
        public async Task<IActionResult> Update(StoreUpdateDto storeDto)
        {
            await _service.UpdateAsync(_mapper.Map<Product>(storeDto));

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }

        ///DELETE api/products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Remove(int id)
        {
            var store = await _service.GetByIdAsync(id);




            await _service.RemoveAsync(store);

            return CreateActionResult(CustomResponseDto<NoContentDto>.Success(204));
        }
        /// api/stores/GetSingleStoreByIdWithProducts/2
        [HttpGet("[action]/{storeId}")]
        public async Task<IActionResult> GetSingleStoreByIdWithProducts(int storeId) => CreateActionResult(await _service.GetSingleStoreByIdWithProductsAsync(storeId));

        private IActionResult CreateActionResult(object value)
        {
            throw new NotImplementedException();
        }
    }


}



