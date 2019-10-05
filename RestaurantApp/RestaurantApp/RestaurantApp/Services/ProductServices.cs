using RestaurantApp.DAL;
using RestaurantApp.Repositories;
using RestaurantApp.Model;

namespace RestaurantApp.Services
{
    public class ProductServices : GenericRepository<RestaurantDB, Products>
    {
    }
}
