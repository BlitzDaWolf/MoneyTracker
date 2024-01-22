using Microsoft.EntityFrameworkCore;
using MoneyTracker.Models;

namespace MoneyTracker.Context
{
    public class AppContext : DbContext
    {
        public AppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PriceActivity> Activities { get; set; }
    }
}
