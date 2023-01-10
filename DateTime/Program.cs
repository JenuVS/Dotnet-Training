//DateTime related functionality



// Empty DateTime



using System.Globalization;

DateTime date = new DateTime();



// Create DateTime from data



DateTime dateOfBirth = new DateTime(1980, 1, 25);
Console.WriteLine($"Date of Birth is {dateOfBirth}:");



//Create DteTime from string



DateTime parsedDate = DateTime.Parse("3/31/2000", CultureInfo.InvariantCulture);
Console.WriteLine($"Parsed date is {parsedDate}");



// Create DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current time is {now}");



// Date to ticks
Console.WriteLine($"Current time is {now.Ticks}");



// Add hours to DateTime
Console.WriteLine($"2 hours from now is {now.AddHours(2)}");



// Dateonly



DateOnly dob = DateOnly.FromDateTime(dateOfBirth);



// TimeOnly



TimeOnly tob = TimeOnly.FromDateTime(dateOfBirth);
Console.WriteLine(tob);