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


// Methods with parameters

// Methods with optional parameters

// Methods with nullable parameters


/* Function Calls */
PrintName();                                              
int fiveYearsAgo = GetFiveYearsAgo();                       
Console.WriteLine($"Five Years Ago was: {fiveYearsAgo}");                      