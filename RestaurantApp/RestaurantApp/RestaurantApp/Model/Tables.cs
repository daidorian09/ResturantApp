using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Model
{
    public class Tables
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual TableStatus tableStatus {get;set;}
        public virtual ICollection<Checkouts> checkOut { get; set; }
        public string labelPriceTag { get; set; }
        public string publicName { get; set; }
    }
}
