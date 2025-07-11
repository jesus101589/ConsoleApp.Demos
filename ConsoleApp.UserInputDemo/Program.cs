namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string name = string.Empty; // Used to initialize the string variable
            int age = 0; // Used to initialize the integer variable
            int retirementAge = 65; // Used to initialize the retirement age

            // Prompt the user for input
            Console.WriteLine("Please enter your name:");
            name = Console.ReadLine(); // Makes console wait for input

            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;

            // Output the results to the user
            Console.WriteLine($"Full name: {name}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");

        }
    }
}
