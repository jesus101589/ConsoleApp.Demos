// See https://aka.ms/new-console-template for more information

// Welcome to the Sample Calculator Console Application!
Console.WriteLine("Welcome to the Sample Calculator Console Application!");

// Show calculator options / Show Menu
Console.WriteLine("Please select an operation");
Console.WriteLine("1. Addition");
Console.WriteLine("2. Subtraction");
Console.WriteLine("3. Multiplication");
Console.WriteLine("4. Division");
int choice = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter the second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// Decide which operation is needed based on selected option
//if(choice == 1)
////{
////    /* Addition */
////}
////else if(choice == 2)
////{
////    /* Subtraction */
////}
////else if(choice == 3)
////{
////    /* Multiplication */
////}
////else if(choice == 4)
////{
////    /* Division */
////}
////else
////{
////    Console.WriteLine("Invalid choice. Please select a valid operation.");
////}

/* Switch statement to handle operations */
int answer = 0;
switch (choice)
{
    case 1:
        answer = num1 + num2;
        break;
    case 2:
        answer = num1 - num2;
        break;
    case 3:
        answer = num1 * num2;
        break;
    case 4:
        answer = num1 / num2;
        break;
    default:
        Console.WriteLine("Invalid choice. Please select a valid operation.");
        break;
}
// Print output

Console.WriteLine($"The result is: {answer}");