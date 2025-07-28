Console.WriteLine("********** - Arrays - **********");

// Declare Fixed Size Array
int[] grades = new int[5];
// Here we defined 5 addresses/indexes in memory for the grades array 0, 1, 2, 3, and 4.
// IF n is the size of the array, then your array will have addresses from 0 to n-1.

// Add values to the Fixed Size Array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

for (int i = 0; i < grades.Length; i++)
{
    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in the Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < grades.Length; i++)
{ 
    Console.WriteLine(grades[i]);
}

// Declare Variable sized Array
string[] studentNames = { "Jesus", "Kelly", "Smokey" };

// Add values to the Variable sized Array

for (int i = 0; i < studentNames.Length; i++)
{
    Console.Write("Enter Student Name: ");
    studentNames[i] = Console.ReadLine();
}

// Print values in the Variable sized Array
Console.WriteLine("The student names you have entered are: ");
for (int i = 0; i < studentNames.Length; i++)
{
    Console.WriteLine(studentNames[i]);
}