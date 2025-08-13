using Service_Repo_Product.Models;

namespace Service_Repo_Product.Interfaces
{
    public interface IProductService
    {
        IEnumerable<Product> GetAll();
        Product GetById(int id);
        void Add(Product pdt);
        void Update(Product pdt);
        void Delete(int id);
    }
}
