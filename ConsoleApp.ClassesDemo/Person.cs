// See https://aka.ms/new-console-template for more information
// Define a class
public class Person
{
    // Properties/Data members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }
}