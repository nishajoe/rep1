using Microsoft.AspNetCore.Mvc;
using Service_Repo_Product.Interfaces;

namespace Service_Repo_Product.Models
{
    public class ProductRepository:IProductRepository
    {
        private readonly AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Product> GetAll()
        {
            return _context.Products.ToList();
        }

        public Product GetById(int id)
        {
            return _context.Products.Find(id);
        }

        public void Add(Product p)
        {
            _context.Products.Add(p);
            _context.SaveChanges();
        }

        public void Update(Product p)
        {
            _context.Products.Update(p);
            _context.SaveChanges();
        }

        public void Delete(int id)
        {
            var pdt=_context.Products.Find(id);
            _context.Remove(pdt);
            _context.SaveChanges();
        }

     
    }
}
