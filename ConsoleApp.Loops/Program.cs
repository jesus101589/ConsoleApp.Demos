// See https://aka.ms/new-console-template for more information

// Simple For Loop Demo
// Print Hello, World! 10 times
// 0 1 2 3 4 5 6 7 8 9
for(int i = 0; i < 10; i++)
{
    Console.WriteLine($"Hello, World! - {i}");
}

Console.WriteLine("Loop completed!");

// Ask user how many times they wish to print hello world and print accordingly
//Console.Write("How many times would you like to print 'Hello, World!'? ");
//int userCount = Convert.ToInt32(Console.ReadLine());

//for(int i = 0; i < userCount; i++)
//{
//    Console.WriteLine($"Hello, World! - {i}");
//}

Console.WriteLine("*************** Simple For Loop Demo Completed ***************");

// While Loop Demo
Console.WriteLine("*************** While Loop Demo ***************");

int counter = 0;
while(counter < 10)
{
    Console.WriteLine($"Hello, World! - {counter}");
    counter += 2; // Increment by 2
}

// Ask the user for a number and find the total for each number that is entered. Print final sum when the user enters -1 to exit.
int sum = 0;
int num = 0;
while(num != -1)
{
    Console.Write("Please enter numbers to sum them up. (Enter -1 to exit.): ");
    num = Convert.ToInt32((Console.ReadLine()));
    // Nested if Statement   
    if(num != -1)
    {
        sum += num;
    }
    
}
Console.WriteLine($"The total sum is: {sum}");


Console.WriteLine("*************** While Loop Completed ***************");


Console.WriteLine("*************** Do While Loop ***************"); // runs through loop at least once then checks condition as opposed to while loop which checks condition first
sum = 0; // Reset sum for Do While Loop
num = 0; // Reset num for Do While Loop
do
{
    Console.Write("Please enter numbers to sum them up. (Enter -1 to exit.): ");
    num = Convert.ToInt32((Console.ReadLine()));
    if (num != -1)
    {
        sum += num;
    }

} while(num != -1);
Console.WriteLine($"The total sum is: {sum}");
Console.WriteLine("*************** Do While Loop Completed ***************");