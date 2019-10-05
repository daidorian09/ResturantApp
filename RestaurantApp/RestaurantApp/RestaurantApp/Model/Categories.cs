using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class Categories
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Products> product { get; set; }
        public DateTime createdAt { get; set; }
    }
}
