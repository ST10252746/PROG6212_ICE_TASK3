namespace PROG6212_ICE_TASK_3
{
    public class Transaction
    {
        public string TransactionID { get; set; } = Guid.NewGuid().ToString();
        public double Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Type { get; set; } 
        public string? Category { get; set; } 
        public string? Description { get; set; }
    }
}
