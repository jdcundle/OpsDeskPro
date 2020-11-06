using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpsDeskProAPI.Models
{
    public class Address
    {
        public Guid ID { get; set; }
        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string Line3 { get; set; }
        public string City { get; set; }
        public Guid ProvinceID { get; set; }
        public Guid CountryID { get; set; }
        public string PostalCode { get; set; }


    }
}
