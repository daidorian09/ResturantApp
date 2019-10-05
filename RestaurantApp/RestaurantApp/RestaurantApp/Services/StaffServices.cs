using RestaurantApp.DAL;
using RestaurantApp.Model;
using RestaurantApp.Repositories;

namespace RestaurantApp.Services
{
    public partial class StaffServices : GenericRepository<RestaurantDB, Staffs>, IWindowsFormSecureWithSHA512
    {
        public string SHA512(string password)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(password + "0106bbcc70da8a97540d2b3da794eb3da011fdb6a963625856aadf3938a77");
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                return hashedInputStringBuilder.ToString();
            }
        }
    }
}
