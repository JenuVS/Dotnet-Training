//  Implement the equation (((a + b) / c) * a)

int a = 0, b = 0, c=0;
int eqa = 0;

Console.Write("Enter value for a : ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value for b : ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter value for c : ");
c = Convert.ToInt32(Console.ReadLine());

eqa = (((a + b) / c) * a);

Console.WriteLine($"(((a + b) / c) * a) : {eqa}");
