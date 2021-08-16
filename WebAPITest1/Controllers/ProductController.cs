using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPITest1.Model;
using WebAPITest1.Repository.IRepository;

namespace WebAPITest1.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
       
        private readonly IProductRepository _productrepo;

        public ProductController(IProductRepository productrepo)
        {
            _productrepo = productrepo;
        }

     

        //[HttpGet]
        //public Product GetProduct(int id)
        //{
        //    return _productrepo.GetProduct(id);
            
        //}

        [HttpGet]
        public IActionResult GetProducts()
        {
            var result= _productrepo.GetProductList();
            return Ok(result);

        }
    }
}
