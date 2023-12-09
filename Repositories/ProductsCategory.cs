using Microsoft.EntityFrameworkCore;
using ptm_store_service.Data;
using ptm_store_service.Repositories.Interface;
using System.Collections.Generic;
using System.Linq;

namespace ptm_store_service.Repositories
{
    public class ProductsCategory : IProductsRepository
    {
        private readonly MyDbContext _context;

        public ProductsCategory(MyDbContext context)
        {
            _context = context;
        }

        public void CreateProduct(Products product)
        {
            _context.Products.Add(product);
            _context.SaveChanges();
        }

        public void DeleteProduct(Products product)
        {
            _context.Products.Remove(product);
            _context.SaveChanges();
        }

        public List<Products> GetAllProducts()
        {
            var products = _context.Products.ToList();
            return products;
        }

        public Products GetProductsById(int id)
        {
            var product = _context.Products.Find(id);
            return product;
        }

        public void UpdateProduct(Products product)
        {
            _context.Products.Update(product);
            _context.SaveChanges();
        }
    }
}
