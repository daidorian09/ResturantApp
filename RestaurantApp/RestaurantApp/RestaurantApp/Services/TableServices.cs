using RestaurantApp.DAL;
using RestaurantApp.Repositories;
using RestaurantApp.Model;
using System;

namespace RestaurantApp.Services
{
    public partial class TableServices : GenericRepository<RestaurantDB, Tables>
    {
    }
}
