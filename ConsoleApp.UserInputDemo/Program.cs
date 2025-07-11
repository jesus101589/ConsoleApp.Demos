namespace ConsoleApp.UserInputDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string firstName = string.Empty; // Used to initialize the string variable
            string lastName = string.Empty; // Used to initialize the string variable
            int age = 0; // Used to initialize the integer variable
            int retirementAge = 65; // Used to initialize the retirement age

            // Prompt the user for input
            Console.WriteLine("Please enter your first name:");
            firstName = Console.ReadLine(); // Makes console wait for input

            Console.WriteLine("Please enter your last name:");
            lastName = Console.ReadLine(); // Makes console wait for input

            Console.WriteLine("Please enter your age:");
            age = Convert.ToInt32(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;

            // Output the results to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Working years remaining: {workingYearsRemaining}");

        }
    }
}
