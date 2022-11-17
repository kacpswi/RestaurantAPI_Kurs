using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI_v2.Authorization
{
    public class MinimumRestaurantRequirement : IAuthorizationRequirement
    {
        public int MinimumRestaurant { get; }

        public MinimumRestaurantRequirement(int minimumRestaurant)
        {
            MinimumRestaurant = minimumRestaurant;
        }
    }
}
