//using Microsoft.AspNetCore.Mvc;
//using ProductCatalogAPI.Models;

//var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
//builder.Services.AddOpenApi();

//var app = builder.Build();

// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
//{
//    app.MapOpenApi();
//}

//app.UseHttpsRedirection();

//app.UseAuthorization();

//app.MapControllers();

//app.Run();

//----------------------- Project structure -----------------------

//Controllers /
//    ProductsController.cs
//Services /
//    IProductService.cs
//    ProductService.cs
//Models/
//    Product.cs
//Program.cs

//--------------------- Product Model ------------------------------

//    namespace ProductCatalogAPI.Models
//{
//    public class Product
//    {
//        public int Id { get; set; }
//        public string Name { get; set; }
//        public string Category { get; set; }
//        public decimal Price { get; set; }
//    }
//}

//--------------------- Product Service Interface ------------------------------
//    using ProductCatalogAPI.Models;
//    namespace ProductCatalogAPI.Services
//{
//    public interface IProductService
//    {
//        IEnumerable<Product> GetAllProducts();
//        Product GetProductById(int id);
//        void AddProduct(Product product);
//        void UpdateProduct(Product product);
//        void DeleteProduct(int id);
//    }
//}


//--------------------- Product Service Implementation ------------------------------
//using ProductCatalogAPI.Models;
//using System.Collections.Generic;
//using System.Linq;

//namespace ProductCatalogAPI.Services
//{
//    public class ProductService : IProductService
//    {
//        private readonly List<Product> _products;

//        public ProductService()
//        {
//            _products = new List<Product>
//            {
//                new Product { Id = 1, Name = "Laptop", Category = "Electronics", Price = 50000 },
//                new Product { Id = 2, Name = "Shirt", Category = "Clothing", Price = 1500 }
//            };
//        }
//        public IEnumerable<Product> GetAll()
//        {
//            return _products;
//        }
//        public Product GetById(int id)
//        {
//            return _products.FirstOrDefault(p => p.Id == id);
//        }
//        public IEnumerable<Product> GetByCategory(string category)
//        {
//            return _products.Where(p => p.Category.ToLower() == category.ToLower());
//        }
//        public Product Add(Product product)
//        {
//            product.Id = _products.Max(p => p.Id) + 1;
//            _products.Add(product);
//            return product;
//        }
//        public bool Delete(int id)
//        {
//            var product = GetById(id);
//            if (product == null) return false;

//            _products.Remove(product);
//            return true;
//        }

// ------------------------- Register Dependency Injection ------------------------------
//using ProductCatalogAPI.Services;

//var builder = WebApplication.CreateBuilder(args);

//    builder.Services.AddControllers();

// --------------------------- Controller -----------------------------------
//using Microsoft.AspNetCore.Mvc;
//using ProductCatalogAPI.Models;
//using ProductCatalogAPI.Services;

//namespace ProductCatalogAPI.Controllers
//    {
//        [ApiController]

//   --------------------------------- Get API Products ---------------------------------
//        [HttpGet]
//        public IActionResult GetAll()
//        {
//            return Ok(_service.GetAll());
//        }

// -------------------------------------Get API product name---------------------------------
//        [HttpGet("category/{name}")]
//        public IActionResult GetByCategory(string name)
//        {
//            var products = _service.GetByCategory(name);
//            return Ok(products);
//        }

//      ------------------------------------- Post API---------------------------------

//        [HttpPost]
//        public IActionResult Create(Product product)
//        {
//            var createdProduct = _service.Add(product);

//            return CreatedAtAction(
//                nameof(GetById),
//                new { id = createdProduct.Id },
//                createdProduct);
//        }

//         ------------------------------------- Delete API---------------------------------
//        [HttpDelete("{id:int}")]
//        public IActionResult Delete(int id)
//        {
//            var deleted = _service.Delete(id);

//            if (!deleted)
//                return NotFound();

//            return NoContent();
//        }