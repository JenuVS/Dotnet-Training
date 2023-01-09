// Datatypes(string, int, float, double, char)
string fullname = string.Empty;
int age = 0;
double salary = 0.0;
char gender = char.MinValue;
bool working = false;




Console.Write("Please enter your name : ");
fullname = Console.ReadLine();



Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());



Console.Write("Please enter your salary: ");
salary = Convert.ToDouble(Console.ReadLine());



Console.Write("Please enter your gender(M/F): ");
gender = Convert.ToChar(Console.ReadLine());



Console.Write("Are you working(true/false): ");
working = Convert.ToBoolean(Console.ReadLine());



Console.WriteLine("The name entered is " + fullname);
Console.WriteLine("The name entered is " + age);
Console.WriteLine("The name entered is " + salary);
Console.WriteLine("The name entered is " + gender);
Console.WriteLine("The name entered is " + working);