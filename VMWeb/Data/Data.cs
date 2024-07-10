using Microsoft.EntityFrameworkCore;
using VMWeb.Components.Models;

namespace VMWeb.Data
{
    public class Data : DbContext
    {
        public Data(DbContextOptions<Data> options)
            : base(options)
        {

        }

        public DbSet<UserDataBase> Users { get; set; }
    }
}
