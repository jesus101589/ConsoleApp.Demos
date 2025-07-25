Console.WriteLine("******* - DateTime Manipulation - *******");

// Empty DateTime object
DateTime dateTime = new DateTime();

// Create a DateTime from date and time
var dateofBirth = new DateTime(1989, 10, 15);
Console.WriteLine($"My date of birth is: {dateofBirth}");

var exactDateAndTimeOfBirth = new DateTime(1989, 10, 15, 20, 30, 45, DateTimeKind.Local);
Console.WriteLine($"My date of birth is: {exactDateAndTimeOfBirth}");

Console.WriteLine($"Day of the Week: {dateofBirth.DayOfWeek}");
Console.WriteLine($"Day of the Year: {dateofBirth.DayOfYear}");
Console.WriteLine($"Time of Day: {exactDateAndTimeOfBirth.TimeOfDay}");
Console.WriteLine($"Ticks: {exactDateAndTimeOfBirth.Ticks}");
Console.WriteLine($"Kind: {exactDateAndTimeOfBirth.Kind}");

// Create a DateTime from current timestamp
DateTime now = DateTime.Now;
Console.WriteLine($"Current Date and Time: {now}");

// Create a DateTime from a string
Console.WriteLine("What is your date of birth? (MM/dd/yyyy): ");
string dob = Console.ReadLine();

var userDob = DateTime.Parse(dob);
Console.WriteLine($"Day of the Week: {userDob.DayOfWeek}");
Console.WriteLine($"Day of the Year: {userDob.DayOfYear}");
Console.WriteLine($"Time of Day: {userDob.TimeOfDay}");
Console.WriteLine($"Ticks: {userDob.Ticks}");
Console.WriteLine($"Kind: {userDob.Kind}");

// Change Format DateTime
Console.WriteLine($"Formatted Date of Birth: {userDob.ToString("dd/MM/yyyy")}");
Console.WriteLine($"Formatted Date of Birth: {userDob.ToString("MMM dd, yyyy")}");
Console.WriteLine($"Formatted Date of Birth: {userDob.ToString("dd-MMM-yyyy")}");
Console.WriteLine($"Formatted Date of Birth: {userDob:dddd, dd MMMM, yyyy}");

// Add Additional Time
Console.WriteLine("One hour from now is: " + now.AddHours(1));
Console.WriteLine("One day from now is: " + now.AddDays(1));
Console.WriteLine("One day from now is: " + now.AddDays(-1));



Console.WriteLine("******* - DateTime Offset Manipulation - *******");
// UTC

// DateTimeOffset and TimeZone Information


Console.WriteLine("******* - Date only and Time only Manipulation - *******");

// Date only

// Time only