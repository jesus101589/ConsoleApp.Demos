namespace ConsoleApp.UserInputDemo
{
    using System.Globalization;
    internal class Program
    {
        static void Main(string[] args)
        { 
            // Declare variables
            const int retirementAge = 65;

            string? firstName = string.Empty; // Used to initialize the string variable
            string lastName = string.Empty; // Used to initialize the string variable
            int age;
            DateOnly dob = new DateOnly();
            decimal salary = 0; // Used to initialize the salary variable
            char gender = char.MinValue; // Used to initialize the character variable
            bool working = true; // Used to initialize the boolean variable
           


            // Prompt the user for input
            Console.Write("Please enter your first name: ");
            firstName = Console.ReadLine(); // Makes console wait for input

            Console.Write("Please enter your last name: ");
            lastName = Console.ReadLine(); // Makes console wait for input

            Console.Write("Please enter your date of birth (mm/dd/yyyy): ");
            dob = DateOnly.ParseExact(Console.ReadLine(), "mm/dd/yyyy", CultureInfo.InvariantCulture);
            age = DateTime.Now.Year - dob.Year;

            Console.Write("Please enter your salary: ");
            salary = Convert.ToDecimal(Console.ReadLine());

            Console.Write("Please enter your gender (M/F): ");
            gender = Convert.ToChar(Console.ReadLine().ToUpper());

            Console.Write("Are you working? (true or false): ");
            working = Convert.ToBoolean(Console.ReadLine());

            // Process the data
            int workingYearsRemaining = retirementAge - age;
            var estimatedRetirementDate = DateTime.Now.AddYears(workingYearsRemaining);

            // Output the results to the user
            Console.WriteLine($"Full name: {firstName} {lastName}");
            Console.WriteLine($"Age: {age}");
            Console.WriteLine($"Your Salary is: {salary.ToString("C")}");
            Console.WriteLine($"Your Gender is: {gender}");
            Console.WriteLine($"You Are Employed: {working}");
            Console.WriteLine($"Number of working years remaining: {workingYearsRemaining}");
            Console.WriteLine($"Estimated Retirement Year: {estimatedRetirementDate.Year}");
        }
    }
}
