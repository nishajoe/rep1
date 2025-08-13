﻿using Service_Repo_Product.Interfaces;

namespace Service_Repo_Product.Models
{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _repo;

        public ProductService(IProductRepository repo)
        {
            _repo = repo;
        }

        public IEnumerable<Product> GetAll()
        {
            return _repo.GetAll();
        }

        public Product GetById(int id)
        {
            return _repo.GetById(id);
        }

        public void Add(Product product)
        {
            _repo.Add(product);
        }

        public void Update(Product product)
        {
            _repo.Update(product);
        }

        public void Delete(int id)
        {
            _repo.Delete(id);
        }
    }
}
