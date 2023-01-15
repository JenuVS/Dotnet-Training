public class Statement
{
    public readonly List<Transactions> _transactions;

    public Statement()
    {
        _transactions = new List<Transactions>();
    }

    public void AddToTransactions(Transactions transactionsList)
    {
        _transactions.Add(transactionsList);
    }

    public void PrintTransactions()
    {
        foreach (var item in _transactions)
        {
            Console.WriteLine(item);
        }
    }

    public double Balance()
    {
        double balance = 0.0;
        foreach (var item in _transactions)
        {
            balance += item.Amount;

        }
        return balance;
    }
}