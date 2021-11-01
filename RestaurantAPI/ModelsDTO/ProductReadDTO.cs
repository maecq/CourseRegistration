using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.ModelsDTO
{
    public class ProductReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        //public IEnumerable<ProductReadDTO> Products { get; set; }

    }
}
