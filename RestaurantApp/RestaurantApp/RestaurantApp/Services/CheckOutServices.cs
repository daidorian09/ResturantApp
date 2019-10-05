using RestaurantApp.DAL;
using RestaurantApp.Repositories;
using RestaurantApp.Model;

namespace RestaurantApp.Services
{
    public partial class CheckOutServices : GenericRepository<RestaurantDB, Checkouts>, ICheckOutServices
    {
        public float SumOfTable(int tableId)
        {
            var table = this.Where(q => q.table.id == tableId);
            float total = 0;
            foreach (var item in table)
            {
                total += item.quantity * item.product.price;
            }
            return total;
        }
    }
}
