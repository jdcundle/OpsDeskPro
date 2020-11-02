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

        public DbSet<Member> Member { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Instructor> Instructor { get; set; }
        public DbSet<Person> Person { get; set; }


    }
}
