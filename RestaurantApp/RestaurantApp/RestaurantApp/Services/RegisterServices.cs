using System;
using RestaurantApp.DAL;
using RestaurantApp.Model;
using RestaurantApp.Repositories;

namespace RestaurantApp.Services
{
    public partial class RegisterServices : GenericRepository<RestaurantDB, Register>, IRegisterServices
    {
        public float SumDailyCash()
        {
            float total = 0.0f;
            var register = this.Where(q => q.id > 0);
            foreach (var item in register)
            {
                if (item.registeredAt.ToString("d/MM/yyyy") == DateTime.Today.ToString("d/MM/yyyy"))
                {
                    total += item.dailySumCash;
                }
            }
            return total;
        }
    }
}
