namespace ConsoleApp.Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // first method to get user input
            Console.Write("Please enter the first number: "); 
            int num1 = Convert.ToInt32(Console.ReadLine());

            // second method to get user input
            int num2 = 0;
            Console.Write("Please enter the second number: ");
            string numberEntered = Console.ReadLine();
            num2 = Convert.ToInt32(numberEntered);

            /*
             *  Math Operations and operators
             */


            // add numbers
            int sum = num1 + num2;

            // multiply numbers
            int product = num1 * num2;

            // divide numbers
            int quotient = num1 / num2;

            // subtract numbers 
            int difference = num1 - num2;

            // modulus
            int mod = num1 % num2;

            Console.WriteLine("************* Math Results *************");
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Product: {product}");
            Console.WriteLine($"Quotient: {quotient}");
            Console.WriteLine($"Difference: {difference}");
            Console.WriteLine($"Modulus: {mod}");
            Console.WriteLine();
            Console.WriteLine("************* End Math Results *************");




            /*
             * Logic Operations and Operators
             */

            bool isGreaterThan = num1 > num2;
            bool isLessThan = num1 < num2;
            bool isEqualTo = num1 == num2;
            bool isGreaterThanOrEqualTo = num1 >= num2;
            bool isLessThanOrEqualTo = num1 <= num2;
            bool isNotEqualTo = num1 != num2;


            Console.WriteLine("************* Logic Results *************");
            Console.WriteLine();
            Console.WriteLine($"Is Greater Than: {isGreaterThan}");
            Console.WriteLine($"Is Less Than: {isLessThan}");
            Console.WriteLine($"Is Equal To: {isEqualTo}");
            Console.WriteLine($"Is Greater Than Or Equal To: {isGreaterThanOrEqualTo}");
            Console.WriteLine($"Is Less Than Or Equal To: {isLessThanOrEqualTo}");
            Console.WriteLine($"Is Not Equal To: {isNotEqualTo}");
            Console.WriteLine();
            Console.WriteLine("************* End Logic Results *************");


            /*
             * Assignment Operations and Operators
             */
            // int randomValue = 5;
            // int increaseValue = num1 + 5;

            // num1 = num1 + 5;
            
            

            Console.WriteLine("************* Assignment Results *************");
            Console.WriteLine();
            num1 += 5;
            Console.WriteLine($"Num 1 is increased by 5: {num1}");
            num1 -= 3;
            Console.WriteLine($"Num 1 is reduced by 3: {num1}");
            num1 /= 2;
            Console.WriteLine($"Num 1 is divided by 2: {num1}");
            num1 %= 2;
            Console.WriteLine($"Num 1 mod by 2: {num1}");
            num1 *= 10;
            Console.WriteLine($"Num 1 is multiplied by 2: {num1}");
            Console.WriteLine();
            Console.WriteLine("************* End Assignment Results *************");




        }
    }
}
