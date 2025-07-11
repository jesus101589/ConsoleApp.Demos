namespace ConsoleApp.VariablesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Different datatypes in C#
            /*
                 text - string
                 integer - int
                 decimal - double, float, decimal
                 logical - bool  
            */

            string name = "Jesus Salinas";
            
            Console.WriteLine(name);
            Console.WriteLine("I am " + name); // String concatenation
            Console.WriteLine($"They call me {name}"); // String interpolation
            Console.WriteLine("I was given the name {0}", name); // String formatting

            int age = 35;
            int retirementYearsLeft = 25;
            int retirementAge = age + retirementYearsLeft;

            Console.WriteLine("My age is: " + age);
            Console.WriteLine("My retirement age is: " + retirementAge);

            bool isRetired = false;
            Console.WriteLine("AM I retired? " + isRetired);

        }
    }
}
