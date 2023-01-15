 public class Transactions
{
    public DateOnly TransactionDate { get; set; }
    public double Amount { get; set; }
    public string Category { get; set; }

    public override string ToString()
    {
        return $"Transaction {{ Date = {TransactionDate.ToShortDateString()}, Amount = {Amount}, Description = {Category} }}";
    }
}