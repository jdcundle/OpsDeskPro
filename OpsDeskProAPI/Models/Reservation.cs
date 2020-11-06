using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OpsDeskProAPI.Models
{
    public class Reservation : IReservation
    {
        public Guid Id { get; set; }
        public Guid PersonId { get; set; }
        public DateTime StartDateTime { get; set; }
        public DateTime EndDateTime { get; set; }
    }
}