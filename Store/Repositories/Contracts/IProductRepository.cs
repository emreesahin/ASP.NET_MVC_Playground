using Entities.Models;

namespace Repositories.Contrats
{
    public interface IProductRepository : IRepositoryBase<Product>
    {
        IQueryable<Product> GetAllProducts(bool trackChanges);
    }
}