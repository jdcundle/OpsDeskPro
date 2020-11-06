using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OpsDeskProAPI.Models;

namespace OpsDeskProAPI.Models
{
    public class OpsDeskProContext: DbContext
    {
        public OpsDeskProContext(DbContextOptions<OpsDeskProContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Person { get; set; }
        public DbSet<Member> Member { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Reservation> Reservation { get; set; }
        public DbSet<Aircraft> Aircraft { get; set; }
        public DbSet<PersonType> PersonType { get; set; }
        public DbSet<PersonTypePerson> PersonTypePerson { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PersonTypePerson>()
                .HasKey(ptp => new { ptp.PersonTypeId, ptp.PersonId });
        }

    }
}
