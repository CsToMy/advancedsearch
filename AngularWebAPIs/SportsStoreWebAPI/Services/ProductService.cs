using Common;
using DAL.Interfaces;
using Microsoft.Extensions.Logging;
using SportsStoreWebAPI.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SportsStoreWebAPI.Services
{
    public class ProductService : IProductService
    {
        private readonly ILogger<ProductService> _logger;
        private readonly IProductRepository _productRepository;

        public ProductService(ILogger<ProductService> logger, IProductRepository productRepository)
        {
            _logger = logger;
            _productRepository = productRepository;
        }

        public List<string> GetProductCategories()
        {
            List<string> result;

            try
            {
                result = _productRepository.GetProductCategories();
            }
            catch (Exception e)
            {
                _logger.LogError("Error in ProductService in GetProductCategories: " + e.Message);
                if(e.InnerException != null)
                {
                    _logger.LogError(e.InnerException.Message);
                }
                result = null!;
            }

            return result;
        }

        public List<Product> GetProducts(string category)
        {
            List<Product> result = null!;
            try
            {
                result = _productRepository.GetProducts(category);
            }
            catch(Exception e)
            {
                _logger.LogError("Error in ProductService in GetProductCategories: " + e.Message);
                if (e.InnerException != null)
                {
                    _logger.LogError(e.InnerException.Message);
                }
            }

            return result;
        }

        public List<Product> SearchProduct(ProductExt productFilter)
        {
            List<Product> result = null!;
            try
            {
                result = _productRepository.SearchProduct(productFilter).ToList();
            }
            catch (Exception e)
            {
                _logger.LogError("Error in ProductService in GetProductCategories: " + e.Message);
                if (e.InnerException != null)
                {
                    _logger.LogError(e.InnerException.Message);
                }
            }

            return result;
        }
    }
}
