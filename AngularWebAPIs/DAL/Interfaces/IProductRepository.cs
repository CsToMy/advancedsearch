using Common;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Interfaces
{
    public interface IProductRepository
    {
        List<Product> GetProducts(string category);
        List<string> GetProductCategories();
        IQueryable<Product> SearchProduct(ProductExt productFilter);
    }
}
