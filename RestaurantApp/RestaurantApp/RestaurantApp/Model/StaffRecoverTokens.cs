using System;
using System.ComponentModel.DataAnnotations;

namespace RestaurantApp.Model
{
    public class StaffRecoverTokens
    {
        public int id { get; set; }
        public string email { get; set; }
        [MaxLength(10)]
        public string token { get; set; }
        public DateTime requestedAt { get; set; }
    }
}
