using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class Checkouts
    {
        public int id { get; set; }
        public virtual Products product { get; set; }
        public int quantity { get; set; }
        public DateTime orderedAt { get; set; }
        public virtual Tables table { get; set; }
    }
}
