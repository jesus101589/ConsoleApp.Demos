// Define a class
using System.ComponentModel.Design;
using System.Security.Cryptography;

namespace ConsoleApp.ClassesDemo.Classes.PersonDemo;

public class Person
{

    public Person() 
    { 
    
    }

    public Person(string firstName, string lastName, DateOnly dob) 
    {
        FirstName = firstName;
        LastName = lastName;
        DateOfBirth = dob;
    }

    public Person(string firstName, string lastName, string taxNumber)
    {
        FirstName = firstName;
        LastName = lastName;
        _taxNumber = taxNumber;
    }

    // Properties/Data members
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateOnly DateOfBirth { get; set; }

    // Field Number
    private string _taxNumber;
    protected string _idNumber = "N/A";

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
        if (string.IsNullOrEmpty(_taxNumber))
        {
            // Generate a random tax number if it is not already set
            // Using RandomNumberGenerator for better randomness
            _taxNumber = GetRandomNumber();
        }
        else
        {
            Console.WriteLine("Tax number already generated.");
        }
    }
    

    public string GetTaxNumber()
    { 
        return _taxNumber;
    }

    public string GetIdNumber() 
    {
        return _idNumber;
    }

    public int GetAge() 
    {
        var age = DateTime.Now.Year - DateOfBirth.Year;
        return age;
    }

    public int GetAge(int year) 
    {
        var age = year - DateOfBirth.Year;
        return age;
    }

    protected string GetRandomNumber() 
    {
        return RandomNumberGenerator.GetInt32(100000, 999999).ToString();
    }
}