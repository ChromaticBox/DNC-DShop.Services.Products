﻿using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using DShop.Messages.ReadModels;
using DShop.Services.Products.Services;
using Microsoft.AspNetCore.Mvc;

namespace DShop.Services.Products.Controllers
{
    [Route("api/[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
            dynamic a = 2;
            a.GetType();
        }

        [HttpGet("{id}/Details")]
        public async Task<ProductDetailsReadModel> GetProductDetailsAsync(Guid id)
            => await _productsService.GetProductDetailsAsync(id);

        [HttpGet("All")]
        public async Task<IEnumerable<ProductReadModel>> GetAllProductsAsync()
            => await _productsService.GetAllProductsAsync();

        [HttpGet("Filtered")]
        public async Task<IEnumerable<ProductReadModel>> GetProductsByVendorAsync([FromQuery] string vendor)
            => await _productsService.GetProductsByVendorAsync(vendor);
    }
}
