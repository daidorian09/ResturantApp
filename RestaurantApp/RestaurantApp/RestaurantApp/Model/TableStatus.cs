using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace RestaurantApp.Model
{
    public class TableStatus
    {
        public int id { get; set; }
        public string name { get; set; }
        public virtual ICollection<Tables> table { get; set; }
    }
}