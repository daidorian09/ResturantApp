using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestaurantApp.Model;

namespace RestaurantApp.DAL
{
    public class RestaurantDB : DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
        public RestaurantDB() : base("resturantDB")
        {
        }

        public DbSet<Categories> categories { get; set; }
        public DbSet<Checkouts> checkouts { get; set; }
        public DbSet<Departments> departments { get; set; }
        public DbSet<Products> products { get; set; }
        public DbSet<Register> register { get; set; }
        public DbSet<Staffs> staffs { get; set; }
        public DbSet<Tables> tables { get; set; }
        public DbSet<TableStatus> tableStatus { get; set; }
        public DbSet<StaffRecoverTokens> staffRecoverTokens { get; set; }

    }
}
