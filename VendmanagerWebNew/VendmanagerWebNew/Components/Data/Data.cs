using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace VendmanagerWebNew.Components.Data
{
    public class Data
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
                : base(options)
            {
            }

            public DbSet<Batch> Batches { get; set; }

            // Override OnModelCreating if you need to configure your models
            protected override void OnModelCreating(ModelBuilder modelBuilder)
            {
                base.OnModelCreating(modelBuilder);
                // Configure your model here

                modelBuilder.Entity<Batch>().HasKey(b => b.record_id); // Assuming record_id is your primary key
            }
        }

        public class Batch
        {
            [Key]
            public int record_id { get; set; }
            public DateTime end_date { get; set; }
            public int batchno { get; set; }
            public int status { get; set; }
            public DateTime create_time { get; set; }
        }

    }
}
