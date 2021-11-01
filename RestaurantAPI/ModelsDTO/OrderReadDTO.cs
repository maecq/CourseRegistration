using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.ModelsDTO
{
    public class OrderReadDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public IEnumerable<ProductReadDTO> Products { get; set; }

    }
}
