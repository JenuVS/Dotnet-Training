// Guess the number

int num = 0;
Random rnd= new Random();
int x = rnd.Next(0,100);

for (int i = 4; i >=0; i--)
{
    Console.Write("Guess the number : ");
    num = Convert.ToInt32(Console.ReadLine());
    if (i > 0)
    {
        if (num < x)
        {
            Console.WriteLine("Guessed number is less than x");
        }

        else if (num > x)
        {
            Console.WriteLine("Guessed number is greater than x");
        }
        else
        {
            Console.WriteLine("You win");
            break;
        }
    }
    else
    {
        Console.WriteLine("You Lose");
    }
    Console.WriteLine($"Remaining chances : {i}");
}
Console.WriteLine();
Console.WriteLine("For loop exited");