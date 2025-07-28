Console.WriteLine("********** - Arrays - **********");

// Tell me how many students and grades are to be entered
Console.Write("Please indicate the number of grades to be entered: ");
int numberOfGrades = Convert.ToInt32(Console.ReadLine());

// Declare Fixed Size Array
int[] grades = new int[numberOfGrades];
string[] students = new string[numberOfGrades];
// Here we defined 5 addresses/indexes in memory for the grades array 0, 1, 2, 3, and 4.
// IF n is the size of the array, then your array will have addresses from 0 to n-1.

// Add values to the Fixed Size Array
//grades[0] = 45;
//grades[1] = 25;
//grades[2] = 38;
//grades[3] = 45;
//grades[4] = 54;

for (int i = 0; i < numberOfGrades; i++)
{
    Console.Write("Enter Student Name: ");
    students[i] = Console.ReadLine();

    Console.Write("Enter Grade: ");
    grades[i] = Convert.ToInt32(Console.ReadLine());
}

// Print values in the Fixed Size Array
Console.WriteLine("The Grades you have entered are: ");
for (int i = 0; i < numberOfGrades; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

// Print values in list - foreach loop
//foreach (int g in grades)
//{
//    Console.WriteLine(g);
//}

//// Declare Variable sized Array
//string[] studentNames = { "Jesus", "Kelly", "Smokey" };

// Add values to the Variable sized Array
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.Write("Enter Student Name: ");
//    studentNames[i] = Console.ReadLine();
//}

//// Print values in the Variable sized Array
//Console.WriteLine("The student names you have entered are: ");
//for (int i = 0; i < studentNames.Length; i++)
//{
//    Console.WriteLine(studentNames[i]);
//}