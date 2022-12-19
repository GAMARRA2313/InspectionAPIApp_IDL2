using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace InspectionAPI
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<Inspection> Inspections { get; set; }

        public DbSet<InspectionType> InspectionTypes { get; set; }

        public DbSet<Status> Statutes { get; set; }
    }
}
