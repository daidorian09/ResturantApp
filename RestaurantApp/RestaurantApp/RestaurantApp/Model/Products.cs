using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantApp.Model
{
    public class Products
    {
        public int id { get; set; }
        public string name { get; set; }
        public float price { get; set; }
        public virtual Categories category { get; set; }
        public DateTime createdAt { get; set; }
        public virtual ICollection<Checkouts> checkOut { get; set; }
    }
}