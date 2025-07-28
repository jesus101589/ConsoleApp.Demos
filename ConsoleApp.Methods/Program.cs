Console.WriteLine("************ - Methods - ************");

// Void methods - completes a task but does not return a value
void PrintName()
{ 
    // Method code
    Console.WriteLine("Jesus Salinas: Software Engineer");
}

// Value returning methods - returns a value after an operation
int GetFiveYearsAgo()
{
    int year = DateTime.Now.AddYears(-5).Year;
    return year;
}


// Methods with parameters - represents data being passed into the method
void PrintNameWithParams(string name)
{
    // Method code
    Console.WriteLine("Your name is: " + name);
}
int GetYearDifferenceWithParams(int year)

{ 
    int yearDifference = DateTime.Now.Year - year;
    return yearDifference;
}
// Methods with optional parameters - parameter is not required..also has a default value
int GetFutureOrPastYear(int numberOfYears = 0)
{
    var year = DateTime.Now.AddYears(numberOfYears).Year;
    return year;
}
// Methods with nullable parameters
void PrintNameNullableParam(string? name, int? count = 0) 
{
    /*
    if(string.IsNullOrEmpty(name))
    {
       name = "Default Name";
    }
    if(!count.HasValue)
    {
        count = 1;
    }
    */

    name ??= "Default Name"; // If name is null, assign "Default Name"
    count ??= 1; // If count is null, assign 1

    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(name);
    }
}

/* Function Calls */
/*PrintName();                                              
int fiveYearsAgo = GetFiveYearsAgo();                       
Console.WriteLine($"Five Years Ago was: {fiveYearsAgo}");

Console.WriteLine("Enter Your Name");
string name1 = Console.ReadLine();
PrintNameWithParams(name1);

Console.WriteLine("Enter A Year");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDifferenceWithParams(pastYear);
Console.WriteLine($"This Was {yearsAgo} Years Ago");

Console.WriteLine("Enter Number of Years in the Future or Past");
int NumberOfYears = Convert.ToInt32(Console.ReadLine());
var pastYear1 = GetFutureOrPastYear();
Console.WriteLine($"The Year is: {pastYear1}");

var pastYear2 = GetFutureOrPastYear(NumberOfYears);
Console.WriteLine($"The Year is: {pastYear2}"); */

PrintNameNullableParam(null, null);
PrintNameNullableParam("Jesus Salinas", 5);