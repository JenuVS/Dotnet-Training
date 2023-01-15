var statement = new Statement();


statement.AddStatement();
statement.PrintTransactions();
Console.WriteLine($"Balance : {statement.Balance()}");

Console.WriteLine("Enter the month : ");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Net Balance of the month : {statement.NetBalance(month)}");