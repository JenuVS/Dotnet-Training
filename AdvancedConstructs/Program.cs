//concatination


string firstName = "Jenu";
string lastName = "vs";

string fullName = firstName + " " + lastName;


// Length of a string


int length = fullName.Length;
Console.WriteLine($"First name has  {length} letters");


//Replace string parts


string newFirstName = firstName.Replace("nu", "rin");
Console.WriteLine($"New first Name is {newFirstName}");


//spilt


string toSplit = "parvathi, jenu, asif, meghana";
string[] names = toSplit.Split(',');
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}


//compare


string nullString = null;
string emptyString = "";
string whiteSpaceString = " ";



if (string.IsNullOrEmpty(nullString))
{
    Console.WriteLine("nullString is empty or null");
}
if (string.IsNullOrWhiteSpace(whiteSpaceString))
{
    Console.WriteLine("nullString is empty or null");
}

int res = firstName.CompareTo(lastName);


if (firstName.CompareTo(lastName) == 0)
{
    Console.WriteLine("firstname and lastname are equal");
}
if (firstName.Equals(lastName))
{
    Console.WriteLine("firstname and lastname are equal");
}