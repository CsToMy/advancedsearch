using Common;
using System.Collections.Generic;

namespace DAL
{
    internal static class StaticProductSource
    {
        private static List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 0,
                Name = "Product 1",
                Category = "Category 1",
                Description = "Description 1",
                Price = 100,
                Dimensions = new Dimension
                {
                    Height = 30,
                    Length = 20,
                    Weight = 76.2,
                    Width = 230,
                    SizeUnit = "cm",
                    WeightUnit = "kg"
                }
            },
            new Product
            {
                Id = 1,
                Name = "Product 2",
                Category = "Category 1",
                Description = "Description 2",
                Price = 110,
                Dimensions = new Dimension
                {
                    Height = 40,
                    Length = 20,
                    Weight = 57.2,
                    Width = 140,
                    SizeUnit = "cm",
                    WeightUnit = "kg"
                }
            },
            new Product
            {
                Id = 2,
                Name = "Product 3",
                Category = "Category 1",
                Description = "Description 3",
                Price = 100,
                Dimensions = new Dimension
                {
                    Height = 50,
                    Length = 20,
                    Weight = 76.2,
                    Width = 230,
                    SizeUnit = "cm",
                    WeightUnit = "kg"
                }
            },
            new Product
            {
                Id = 3,
                Name = "Product 4",
                Category = "Category 2",
                Description = "Description 4",
                Price = 100,
                Dimensions = new Dimension
                {
                    Height = 30,
                    Length = 20,
                    Weight = 76.2,
                    Width = 230,
                    SizeUnit = "cm",
                    WeightUnit = "kg"
                }
            },
            new Product
            {
                Id = 4,
                Name = "Chess Board",
                Category = "Category 2",
                Description = "Board for playing chess. The package contains black and white figures.",
                Price = 75.89,
                Dimensions = new Dimension
                {
                    Height = 10,
                    Length = 45,
                    Weight = 1750,
                    Width = 45,
                    SizeUnit = "cm",
                    WeightUnit = "gramm"
                }
            }
        };

        public static List<Product> Products
        {
            get { return _products; }
        }

    }
}
