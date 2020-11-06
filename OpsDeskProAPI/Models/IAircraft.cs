using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpsDeskProAPI.Models
{
    interface IAircraft
    {
        public Guid Id { get; set; }
        public string Registration { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
    }
}
