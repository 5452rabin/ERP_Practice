using Microsoft.AspNetCore.Mvc;
using Microsoft.Build.Framework;
using Microsoft.VisualBasic;
using Practise.Models;
using Practise.Services.Interface;
using System.Collections.Generic;

namespace Practise.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService) 
        {
        _productService = productService;
        }


        public class ProductModel
        {
            public string ProductPrice { get; set; }
            public string ProductName { get; set; }
            public string ProductDescription { get; set; }
        }
        [HttpPost]
        public JsonResult CreateProduct(ProductModel model)
        {
            try

            { 
                if (string.IsNullOrEmpty(model.ProductPrice) || string.IsNullOrEmpty(model.ProductName) || string.IsNullOrEmpty(model.ProductDescription))
                {
                    return Json(new { msg = "error", error = "All fields are required" });
                }

                if (!decimal.TryParse(model.ProductPrice, out decimal price))
                {
                    return Json(new { msg = "error", error = "Invalid price format" });
                }

               
                Product product = new Product()
                {
                    Price = price,
                    Name = model.ProductName,
                    Description = model.ProductDescription
                };

           
                product = _productService.AddProduct(product);

         
                return Json(new { msg = "success" });
            }
            catch (Exception ex)
            {
        
                return Json(new { msg = "error", error = ex.Message });
            }
        }
        [HttpGet]
        public JsonResult GetAllProduct()
        {
            List<Product> products = _productService.GetAllProducts();
            return Json(products);
        }
        public JsonResult GetProductById(int id)
        {
            Product product=_productService.GetProductById(id);
            return Json(product);
        }
        public IActionResult GetProduct(string productname)
        {
            List <Product> products= _productService.GetAllProducts();
            if (string.IsNullOrEmpty(productname))
            {
                 return View(products);
            }
            else
            {
                products=products.Where(x=>x.Name==productname).ToList();
                return View(products);
            }
            
        }
    }
}
