namespace ConsoleApp.ConditionsandDecisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt for input
            Console.Write("Please enter student's grade: ");
            int grade = Convert.ToInt32(Console.ReadLine());

            // Simple if..else statement - decide to print pass or fail based on input.
            Console.WriteLine("*************** Simple IF results ***************");
            if (grade > 50)
            { 
                Console.WriteLine("Student has passed");
            }
            else
            {
                Console.WriteLine("Student has failed");
                Console.WriteLine("Please recommend student to student affair's office");
            }
            Console.WriteLine("*************** Simple IF results end ***************");

            // Complex if..else if statement - decide to print letter grade based on input.
            Console.WriteLine("*************** Complex IF..ELSE IF results ***************");

            /*
             * A: 86 - 100
             * B: 75 - 84
             * C: 65 - 74
             * C-: 51 - 64 x
             * F: less than 50 x
             */
            if (grade < 0 || grade > 100)
            {
                Console.WriteLine("Invalid grade entered. Please enter a grade between 0 and 100.");
            }
            else if (grade < 50)
            {
                Console.WriteLine("Student has failed - F");
            }
            else if (grade >= 50 && grade <= 64)
            {    
                Console.WriteLine("C-");
            }
            else if (grade >= 65 && grade <= 74)
            {
                Console.WriteLine("C");
            }
            else if (grade >= 75 && grade <= 84)
            {
                Console.WriteLine("B");
            }
            else if (grade >= 85 && grade <= 100)
            {
                Console.WriteLine("A - Good job");
            }
            else
            {
                Console.WriteLine("Invalid grade entered");
            }


            Console.WriteLine("*************** Complex IF..ELSE IF results end ***************");

            // Ternary operator - Used to assign a value to a variable based on a condition.
            Console.WriteLine("*************** Ternary Operator Result ***************");

            string passStatus = grade < 50 ? "Student has failed" : "Student has passed";
            Console.WriteLine($"Student Status: {passStatus}");

            Console.WriteLine("*************** Ternary Operator Result End ***************");
            
            // The rest of the application
            Console.WriteLine("Thank you for using this program");


        }
    }
}
