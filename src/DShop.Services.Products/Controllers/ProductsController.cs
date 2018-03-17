﻿using System;
using System.Threading.Tasks;
using DShop.Services.Products.Dtos;
using DShop.Services.Products.Services;
using Microsoft.AspNetCore.Mvc;

namespace DShop.Services.Products.Controllers
{
    [Route("[controller]")]
    public class ProductsController : Controller
    {
        private readonly IProductsService _productsService;

        public ProductsController(IProductsService productsService)
        {
            _productsService = productsService;
        }

        [HttpGet("{id}")]
        public async Task<ProductDto> GetAsync(Guid id)
            => await _productsService.GetAsync(id);
    }
}
