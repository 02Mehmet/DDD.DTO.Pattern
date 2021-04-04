using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QLTEQ.Domain.Products;
using QLTEQ.DTOPattern.ViewModel.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QLTEQ.WEBAPI.Controllers
{
    [Route("api/v1/pruduct")]
    [ApiController]
    public class Product : ControllerBase
    {
        public IProductRepository _productRepository;

        public Product(IProductRepository productRepository)
        {
            this._productRepository = productRepository;
        }

        [HttpPost]
        [Route("getproduct")]
        public List<ProductResponseGet> GetProducts(List<string> ids)
        {
            var result = this._productRepository.GetByIds(ids);

            return result;
        }

        [HttpPost]
        [Route("getallproduct")]
        public List<ProductResponseGet> GetAllProduct()
        {
            var result = this._productRepository.GetAll();

            return result;
        }
    }
}
