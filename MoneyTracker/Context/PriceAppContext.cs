using Microsoft.EntityFrameworkCore;
using MoneyTracker.Models;

namespace MoneyTracker.Context
{
    public class PriceAppContext : DbContext
    {
        public PriceAppContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<PriceActivity> Activities { get; set; }
    }
}
