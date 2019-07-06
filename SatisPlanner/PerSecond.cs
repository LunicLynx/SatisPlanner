namespace SatisPlanner
{
    struct PerSecond
    {
        public int Amount { get; set; }

        public PerSecond(int amount)
        {
            Amount = amount;
        }

        public static implicit operator PerSecond(int amount)
        {
            return new PerSecond(amount);
        }
    }
}