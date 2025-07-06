using Microsoft.EntityFrameworkCore;
using Sales2Cet95.Web.Data.Entities;
namespace Sales2Cet95.Web.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) :base(options)
        {
        
        }

        public DbSet<Country> Countries { get; set; }   

    }
}
