using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestaurantAPI.ModelsDTO
{
    public class OrderWriteDTO
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }        
        public IEnumerable<int> ProductIds { get; set; }

    }
}
