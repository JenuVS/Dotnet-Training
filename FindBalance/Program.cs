var statement = new Statement();

void addStatement()
{
    DateOnly date;
    double amount;
    string category;
    string[] lines = File.ReadAllLines(@"C:\Users\januv\source\repos\Consoleprogramming\FindBalance\test.csv");
    foreach (string item in lines)
    {
        string[] list = item.Split(",");

        date = DateOnly.Parse(list[0]);
        amount = double.Parse(list[1]); 
        category = (list[2]);

        Transactions transactions = new Transactions(date, amount, category);
        statement.AddToTransactions(transactions);
    }
}

addStatement();
statement.PrintTransactions();
Console.WriteLine($"Balance : {statement.Balance()}");