using Example.Core.ProductAggregate.Models;
using Example.Infrastructure.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GenericRepo = Example.Infrastructure.Repositories.GenericRepoExample;

namespace Example.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        ProductRepository _repo;
        GenericRepo.ProductRepository _genericRepo;

        public ProductsController(ProductRepository repo, GenericRepo.ProductRepository genericRepo)
        {
            _repo = repo;
            _genericRepo = genericRepo;
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

        [HttpGet]
        [ActionName("ByNameWithGenericRepo")]
        public async Task<List<Product>> GetByNameGenericRepo(string text)
        {
            _genericRepo.ProductName = text;

            return await _genericRepo.Search();
        }
    }
}
