using Common;
using System.Collections.Generic;

namespace SportsStoreWebAPI.Interfaces
{
    public interface IProductService
    {
        List<Product> GetProducts(string category);
        List<string> GetProductCategories();
        List<Product> SearchProduct(ProductExt productFilter);
    }
}
