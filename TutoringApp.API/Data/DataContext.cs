using Microsoft.EntityFrameworkCore;
using TutoringApp.API.Models;

//https://stackoverflow.com/questions/1279613/what-is-an-orm-how-does-it-work-and-how-should-i-use-one

namespace TutoringApp.API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

       public DbSet<Value> Values { get; set; }
    }
}