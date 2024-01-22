namespace MoneyTracker.Models
{
    public class PriceActivity
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public DateTime Time { get; set; } = DateTime.UtcNow;
        public string Name { get; set; }
        public double Price { get; set; }
        public int Type { get; set; }
    }
}
