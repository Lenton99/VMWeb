using Microsoft.EntityFrameworkCore;
using VMWeb.Models;

namespace VMWeb.Data
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options)
            : base(options)
        {

        }

        public DbSet<Contact> Contacts { get; set; }
    }
}
