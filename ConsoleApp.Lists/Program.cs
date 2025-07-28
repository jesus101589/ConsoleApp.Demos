Console.WriteLine("********** - Lists - **********");

// Declare a List
List<int> grades = new List<int>();
List<string> students = new List<string>();
int grade = 0;
string name;
int gradeCount = 0;
int @continue; // @ is used to avoid keyword conflict with C#
//var grades = new List<int>();
//List<int> grades = new();


// Add values to the List
//grades.Add(45);
//grades.Add(95);
//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]);

do
{
    gradeCount += 1;
    Console.Write("Enter Student Name: ");
    name = Console.ReadLine();
    students.Add(name);

    Console.Write("Enter a grade: ");
    grade = Convert.ToInt32(Console.ReadLine());
    if(grade != -1) 
    {
        grades.Add(grade);
    }

    Console.Write("Do you wan to add another grade? (1 = yes | 2 = no): ");
    @continue = Convert.ToInt32(Console.ReadLine());
} while (@continue == 1);

// Print values in the List - for loop
Console.WriteLine("Printing grades via for loop");
for (int i = 0; i < gradeCount; i++)
{
    Console.WriteLine($"{students[i]}: {grades[i]}");
}

//// Print vain the List - foreach loop
//Console.WriteLine("Printing grades via foreach loop");
//foreach (int g in grades)
//{
//    Console.WriteLine(g);
//}