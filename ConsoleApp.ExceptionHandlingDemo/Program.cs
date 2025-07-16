// See https://aka.ms/new-console-template for more information


// Write a program that takes a user's age as input and prints it to the screen. Display an error message if an invalid input is given (e.g., non-numeric input).
try
{
    Console.Write("Please enter your age: ");
    int age = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"You are {age} years old. ");
}
catch (Exception)
{
    Console.WriteLine("Invalid input. Please enter a numeric value for your age.");
    //throw;
}
finally
{
    Console.WriteLine("****** Thank you for using the age input program. ******");
}