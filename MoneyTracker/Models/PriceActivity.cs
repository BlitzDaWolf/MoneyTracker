namespace MoneyTracker.Models
{
    public class PriceActivity
    {
        public Guid Id { get; set; }
        public DateTime Time { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int Type { get; set; }
    }
}
