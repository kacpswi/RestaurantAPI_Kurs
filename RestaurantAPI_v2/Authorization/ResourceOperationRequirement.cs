using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI_v2.Authorization
{
    public enum ResourceOperation
    {
        Create,
        Read,
        Update,
        Delete
    }
    public class ResourceOperationRequirement:IAuthorizationRequirement
    {

        public ResourceOperationRequirement(ResourceOperation resourceoperation)
        {
            ResourceOperation = resourceoperation;
        }
        public ResourceOperation ResourceOperation { get; }
    }
}
