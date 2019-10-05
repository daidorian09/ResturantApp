using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class Register
    {
        public int id { get; set; }
        public float dailySumCash { get; set; }
        public DateTime registeredAt { get; set; }
    }
}
