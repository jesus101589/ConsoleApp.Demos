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
// Methods with optional parameters

// Methods with nullable parameters


/* Function Calls */
PrintName();                                              
int fiveYearsAgo = GetFiveYearsAgo();                       
Console.WriteLine($"Five Years Ago was: {fiveYearsAgo}");

Console.WriteLine("Enter Your Name");
string name1 = Console.ReadLine();
PrintNameWithParams(name1);

Console.WriteLine("Enter A Year");
int pastYear = Convert.ToInt32(Console.ReadLine());
int yearsAgo = GetYearDifferenceWithParams(pastYear);
Console.WriteLine($"This Was {yearsAgo} Years Ago");