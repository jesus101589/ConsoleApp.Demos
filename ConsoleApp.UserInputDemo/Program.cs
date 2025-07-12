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
            decimal salary = 0; // Used to initialize the salary variable
            char gender = char.MinValue; // Used to initialize the character variable
            bool working = true; // Used to initialize the boolean variable


            // Prompt the user for input
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine(); // Makes console wait for input

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine(); // Makes console wait for input

            Console.Write("Please enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M/F): ");
            gender = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;

            // Output the results to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your Salary is: {salary}");
            Console.WriteLine($"Your Gender is: {gender}");
            Console.WriteLine($"You Are Employed: {working}");
            Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
        }
    }
}
