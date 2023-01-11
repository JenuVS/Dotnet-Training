int cardNum = 12345;
int atmPin = 2255;
int balance = 0;
int choice = 0;
/*bool CheckCredentials()
{
    Console.Write("Enter 5 digit card number : ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter 4 digit card number : ");
    int pin = Convert.ToInt32(Console.ReadLine());
}*/

void DepositAmount()
{
    Console.Write("Enter amount : ");
    int amount = Convert.ToInt32(Console.ReadLine());
    balance += amount;
    Console.WriteLine("Transaction Successfully Completed");
}

void WithdrawAmount()
{
    Console.Write("Enter amount : ");
    int amount = Convert.ToInt32(Console.ReadLine());
    if (amount > balance)
    {
        Console.WriteLine("INSUFFICENT BALANCE");
    }
    else
    {
        balance -= amount;
        Console.WriteLine("Transaction Successfully Completed");
    }
}

void BalanceCheck()
{
    Console.WriteLine($"AVAILABLE BALANCE : {balance}");
}

void UserMenu()
{
    Console.WriteLine("1. Check Balance");
    Console.WriteLine("2. Withdraw Cash");
    Console.WriteLine("3. Deposit Cash");
    Console.WriteLine("4. Quit");
    Console.Write("Enter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
}


try
{
    // CheckCredentials();
    Console.Write("Enter 5 digit card number : ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter 4 digit card number : ");
    int pin = Convert.ToInt32(Console.ReadLine());

    if (num == cardNum && pin == atmPin)
    {
        Console.WriteLine("Welcome to ATM Service");

        while (!choice.Equals(4))
        {
            UserMenu(); 

            Console.Clear();
            switch (choice)
            {
                case 1:
                    BalanceCheck();
                    break;
                case 2:
                    WithdrawAmount();
                    BalanceCheck();
                    break;
                case 3:
                    DepositAmount();
                    BalanceCheck();
                    break;
                case 4:
                    Console.Write("THANK FOR USING THE ATM");
                    break;
                default:
                    Console.WriteLine("Invalid Choice ");
                    break;
            }
        }

    }
    else
    {
        Console.WriteLine("Invalid card number or ATM pin");
    }
}

catch (Exception ex)
{
    Console.WriteLine($"Something went wrong{ex.Message}");
}