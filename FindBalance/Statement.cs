public class Statement
{
    public  List<Transactions> transactions { get; set; } = new List<Transactions>();

    public void AddStatement()
    {
        string[] lines = File.ReadAllLines(@"C:\Users\januv\source\repos\Consoleprogramming\FindBalance\test.csv");
        foreach (string item in lines)
        {
            string[] list = item.Split(",");

            DateOnly date = DateOnly.Parse(list[0]);
            double amount = double.Parse(list[1]);
            string categorey = list[2];

            var statement = new Transactions()
            {
                TransactionDate = date,
                Amount = amount,
                Category = categorey
            };

            transactions.Add(statement);
        }
    }

    public void PrintTransactions()
    {
        foreach ( var item in transactions )
        {
            Console.WriteLine(item);
        }
    }

    public double Balance()
    {
        double balance = 0.0;
        foreach (var item in transactions)
        {
            balance += item.Amount;
        }
        return balance;
    }

    public double NetBalance(int Month)
    {
        double netBalance = 0.0;
        foreach (var item in transactions)
        {
            if (item.TransactionDate.Month == Month)
            {
                netBalance += item.Amount;
            }
        }
        return netBalance;
    }
}