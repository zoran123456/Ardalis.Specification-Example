﻿using Example.Core.ProductAggregate.Models;
using Example.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Example.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductRepository _repo;

        public ProductsController(ProductRepository repo)
        {
            _repo = repo;
        }

        [HttpGet]
        [ActionName("List")]
        public async Task<List<Product>> List()
        {
            return await _repo.ListProducts();
        }

        [HttpGet]
        [ActionName("ByName")]
        public async Task<List<Product>> GetByName(string text)
        {
            return await _repo.SearchForProductByName(text);
        }

        [HttpGet]
        [ActionName("ByDescription")]
        public async Task<List<Product>> GetByDescription(string text)
        {
            return await _repo.SearchForProductByDescription(text);
        }
    }
}
