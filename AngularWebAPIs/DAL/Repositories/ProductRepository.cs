using Common;
using DAL.Interfaces;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DAL.Repositories
{
    public class ProductRepository : IProductRepository
    {
        ILogger<ProductRepository> _logger;
        public ProductRepository(ILogger<ProductRepository> logger)
        {
            _logger = logger;
        }

        public List<string> GetProductCategories()
        {
            List<string> result;
            
            try
            {
                result = StaticProductSource.Products.Select(x => x.Category).Distinct().ToList();
            }
            catch (Exception e)
            {
                _logger.LogError("Error in ProductRepository in GetProductCategories: " + e.Message);
                throw;
            }

            return result;
        }

        public List<Product> GetProducts(string category)
        {
            List<Product> result = null!;

            try
            { 
                result = StaticProductSource.Products;
                if (!String.IsNullOrEmpty(category))
                {
                    result = result.Where(prod => prod.Category.Equals(category)).ToList();
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Error in ProductRepository in GetProducts with paramter {0} as category. Error: {1}", category, e.Message);
                throw;
            }

            return result;
        }

        public IQueryable<Product> SearchProduct(ProductExt productFilter)
        {
            IQueryable<Product> result;

            try
            {
                result = StaticProductSource.Products.AsQueryable();
                
                if(productFilter != null)
                {
                    if (!String.IsNullOrEmpty(productFilter.Name))
                    {
                        result = result.Where(prod => prod.Name.StartsWith(productFilter.Name));
                    }

                    if (!String.IsNullOrEmpty(productFilter.Category))
                    {
                        result = result.Where(prod => prod.Category.StartsWith(productFilter.Category));
                    }

                    if (!String.IsNullOrEmpty(productFilter.Description))
                    {
                        result = result.Where(prod => prod.Description!= null && prod.Description.StartsWith(productFilter.Description));
                    }

                    if(productFilter.PriceFrom != null)
                    {
                        if(productFilter != null)
                        {
                            result = result.Where(prod => prod.Price >= productFilter.PriceFrom && prod.Price <= productFilter.PriceTo);
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception e)
            {
                _logger.LogError("Error in ProductRepository in SearchProduct with paramter {0} as category. Error: {1}", productFilter, e.Message);
                throw;
            }

            return result;
        }
    }
}
