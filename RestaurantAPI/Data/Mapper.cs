using RestaurantAPI.Models;
using RestaurantAPI.ModelsDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.Data
{
    public class Mapper
    {
        public Product Map (ProductDTO input)
        {
            return new Product
            {
                Name = input.Name,
                Price = input.Price
            };
        }

        public ProductDTO Map (Product input)
        {
            return new ProductDTO
            {
                Name = input.Name,
                Price = input.Price
            };
        }
    }
}
