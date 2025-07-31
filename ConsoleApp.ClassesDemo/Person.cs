// Define a class
using System.Security.Cryptography;

public class Person
{
    // Properties/Data members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field Number
    private string _taxNumber;

    public void PrintFullName()
    {
        Console.WriteLine($"Full Name: {FirstName} {LastName}");
    }

    public void PrintInitials()
    {
        Console.WriteLine($"Initials: {FirstName[0]}.{LastName[0]}.");
    }

    public void GenerateTaxNumber()
    {
        _taxNumber = RandomNumberGenerator.GetInt32(100000, 999999).ToString();
    }

    public string GetTaxNumber()
    { 
        return _taxNumber;
    }
}