using ApiDcBell.Models;

namespace ApiDcBell.Repositories
{
    public interface IProductCollection
    {

        Task InsertProduct(Product product);

        Task UpdateProduct(Product product);

        Task DeleteProduct(string id);


        Task<Product> GetProductById(string id);

        Task<List<Product>> GetAllProducts();
       
    }
}
