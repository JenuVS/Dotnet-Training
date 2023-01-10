//Methods

Console.Write("enter number1: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter number2: ");
int num2 = Convert.ToInt32(Console.ReadLine());



void Add(int a, int b)
{
    Console.WriteLine($"Addision: {a + b}");
}
Add(num1, num2);
Add(1, 3);



int GreaterThan(int a, int b, int c)
{
    int largest = a;
    if (b > largest)
    {
        largest = b;
    }
    if (c > largest)
    {
        c = largest;
    }
    return largest;
}
int largest = GreaterThan(10, 15, 8);
Console.WriteLine($"Largest number is {largest}");