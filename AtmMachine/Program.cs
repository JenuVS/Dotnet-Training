int cardNum = 12345;
int atmPin = 2255;
int balance = 0;
int amount = 0;
int choice = 0;

int DepositAmount(int amt)
{
    balance += amount;
    Console.WriteLine("\nTransaction Successfully Completed");
    return balance;
}

int WithdrawAmount(int amt)
{
    balance -= amt;
    Console.WriteLine("\nTransaction Successfully Completed");
    return balance;
}

void BalanceCheck()
{
    Console.Write($"\nAVAILABLE BALANCE : {balance}\n\n");
}

void UserMenu()
{
    Console.WriteLine("1. Check Balance\n");
    Console.WriteLine("2. Withdraw Cash\n");
    Console.WriteLine("3. Deposit Cash\n");
    Console.WriteLine("4. Quit\n");
    Console.Write("\nEnter your choice: ");
    choice = Convert.ToInt32(Console.ReadLine());
}


try
{
    Console.Write("Enter 5 digit card number : ");
    int num = Convert.ToInt32(Console.ReadLine());

    Console.Write("Enter 4 digit card number : ");
    int pin = Convert.ToInt32(Console.ReadLine());

    if (num == cardNum && pin == atmPin)
    {
        Console.WriteLine("\n\nWelcome to ATM Service\n");

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
                    Console.Write("Enter amount : ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    if (amount > balance)
                    {
                        Console.WriteLine("\nINSUFFICENT BALANCE\n");
                    }
                    else
                    {
                        WithdrawAmount(amount);
                        BalanceCheck();
                        break;
                    }
                    break;
                case 3:
                    Console.Write("Enter amount : ");
                    amount = Convert.ToInt32(Console.ReadLine());
                    DepositAmount(amount);
                    BalanceCheck();
                    break;
                case 4:
                    Console.Write("\n THANK FOR USING THE ATM");
                    break;
                default:
                    Console.WriteLine("Inalid Choice ");
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
    Console.WriteLine(ex.Message);
}