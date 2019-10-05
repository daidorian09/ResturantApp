using RestaurantApp.DAL;
using RestaurantApp.Model;
using RestaurantApp.Repositories;

namespace RestaurantApp.Services
{
    public partial class DepartmentServices : GenericRepository<RestaurantDB, Departments>
    {
    }
}
