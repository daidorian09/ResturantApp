using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantApp.Services
{
    interface IWindowsFormSecureWithSHA512
    {
        string SHA512(string email);
    }
}
