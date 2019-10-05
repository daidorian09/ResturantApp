using RestaurantApp.DAL;
using RestaurantApp.Repositories;
using RestaurantApp.Model;

namespace RestaurantApp.Services
{
    public partial class CategoryServices : GenericRepository<RestaurantDB, Categories>
    { 
    }
}
