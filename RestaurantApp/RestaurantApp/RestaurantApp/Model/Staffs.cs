using System;

namespace RestaurantApp.Model
{
    public class Staffs
    {
        public int id { get; set; }
        public string name { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string email { get; set; }
        public string adress { get; set; }
        public string password { get; set; }
        public virtual Departments department { get; set; }
        public DateTime beginingDate { get; set; }
        public DateTime? endingDate { get; set; }
        public DateTime? modifiedAt { get; set; }

    }
}
