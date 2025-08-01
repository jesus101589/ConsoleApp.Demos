// See https://aka.ms/new-console-template for more information
Console.WriteLine("********** - Classes and Objects - **********");

// Define an object of type Person
Person person; // This will be null by default because it is not initialized

Person baby = new Person();
baby.LastName = "Salinas";
baby.FirstName = "Jesus";
baby.DateOfBirth = new DateOnly(2027, 10,31);

//Console.WriteLine($"{baby.FirstName} {baby.LastName}"); // Do not need this line since we created a method to print the full name in the Person file.

baby.PrintFullName(); // Call the method to print the full name
baby.PrintInitials(); // Call the method to print the initials
baby.GenerateTaxNumber(); // Generate a tax number

Console.WriteLine($"Tax Number: {baby.GetTaxNumber()}"); // Get the tax number and print it

var person1 = new Person("Developer", "One", new DateOnly(2005,10,31));
person1.PrintFullName();
person1.PrintInitials();

var person2 = new Person("Developer", "Two", "123456");
person2.PrintFullName();
person2.PrintInitials();
person2.GenerateTaxNumber();