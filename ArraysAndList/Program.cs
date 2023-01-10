// Arrays
// initialised a fixed size array


int[] marks = new int[5]; // 0 besed index (0-4)


// iterate an array


for (int i = 0; i < marks.Length; i++)
{
    Console.Write("Enter marks :");
    marks[i] = Convert.ToInt32(Console.ReadLine());
}


//print an array of elements


for (int i = 0; i < marks.Length; i++)
{
    Console.WriteLine(marks[i]);
}
string[] usernames = new string[] { "Jenu", "abhijith", "savanth" };


// Lists


List<string> devs = new List<string>();
string dev = string.Empty;
while (!dev.Equals("-1"))
{
    Console.Write("Enter the name of the develepor: ");
    dev = Console.ReadLine();
    if (dev != string.Empty && !dev.Equals("-1"))
    {
        devs.Add(dev);
    }
}
foreach (string name in devs)
{
    Console.WriteLine(name);
}