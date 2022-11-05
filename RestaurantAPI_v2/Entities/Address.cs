using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantAPI_v2.Entities
{
    public class Address
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string Street {get;set;}
        public string PostalCode { get; set; }
        public virtual Restaurant Restaurant { get; set; }
    }
}
