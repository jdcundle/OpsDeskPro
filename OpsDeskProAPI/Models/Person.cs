using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpsDeskProAPI.Models
{
    public class Person: IPerson
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public Address[] AddressList { get; set; }

    }
}
