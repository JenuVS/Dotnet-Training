// Exception Handling


Console.Write("Enter number 1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number 2: ");
int num2 = Convert.ToInt32(Console.ReadLine());
try
{
    double quotient = num1 / num2;
    Console.WriteLine($"result is {quotient}");
}
catch (DivideByZeroException e)
{
    Console.WriteLine($"Illegal operation performed {e.Message}");
}
catch (Exception ex)
{
    Console.WriteLine("Excited the program");
}