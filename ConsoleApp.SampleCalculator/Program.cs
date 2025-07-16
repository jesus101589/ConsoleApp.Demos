// See https://aka.ms/new-console-template for more information

// Welcome to the Sample Calculator Console Application!
using System.ComponentModel.DataAnnotations;

Console.WriteLine("Welcome to the Sample Calculator Console Application!");

// Variable Declarations
int choice = 0;
int num1, num2 = 0;

// Show calculator options / Show Menu
while (choice != -1)
{ 
    Console.WriteLine("Please select an operation (-1 to exit program) ");
    Console.WriteLine("1. Addition");
    Console.WriteLine("2. Subtraction");
    Console.WriteLine("3. Multiplication");
    Console.WriteLine("4. Division");
    Console.WriteLine("5. Fibonacci Sequence");
    try
    {
        choice = Convert.ToInt32(Console.ReadLine());
    }
    catch(Exception)
    {
        Console.WriteLine("Invalid input. Press any key to continue and please enter a number corresponding to the operation.");
        Console.ReadLine(); // Wait for user to acknowledge the error
        Console.Clear(); // Clear the console for a fresh start
        continue; // Skip to the next iteration of the loop
    }

    if(choice == -1)
    {
        break; // Exit the loop if user chooses to exit
    }

    try
    {
        Console.Write("Please enter the first number: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter the second number: ");
        num2 = Convert.ToInt32(Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Invalid input. Please enter a number corresponding to the operation.");
        Console.ReadLine(); // Wait for user to acknowledge the error
        Console.Clear(); // Clear the console for a fresh start
        continue; // Skip to the next iteration of the loop
    }

    

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
            try
            {
                answer = num1 / num2;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
                Console.WriteLine("Press Enter to continue...");
                Console.ReadLine();
                Console.Clear(); // Clear the console for a fresh start
                continue; // Skip to the next iteration of the loop
            }
            catch (Exception)
            {
                throw;
            }
            break;
        case 5:
            for (int i = 0; i <= num2; i++)
            {
                answer += i;
            }
            break;
        default:
            Console.WriteLine("Invalid choice. Please select a valid operation.");
            Console.WriteLine("Press Enter to continue...");
            Console.ReadLine();
            Console.Clear(); // Clear the console for a fresh start
            continue;
    }
    // Print output
    Console.WriteLine($"The result is: {answer}");
    Console.WriteLine("Press Enter to continue...");
    Console.ReadLine();
    Console.Clear();

}

Console.WriteLine("*** Thank you for using the Sample Calculator Console Application! ***");