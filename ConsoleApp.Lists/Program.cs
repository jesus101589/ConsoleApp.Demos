Console.WriteLine("********** - Lists - **********");

// Declare a List
List<int> grades = new List<int>();
int grade = 0;
//var grades = new List<int>();
//List<int> grades = new();


// Add values to the List
//grades.Add(45);
//grades.Add(95);
//Console.WriteLine(grades[0]);
//Console.WriteLine(grades[1]);

do
{
    Console.Write("Enter a grade: (enter -1 to stop) ");
    grade = Convert.ToInt32(Console.ReadLine());
    if(grade != -1) 
    {
        grades.Add(grade);
    }
} while (grade != -1);

// Print values in the List - for loop
Console.WriteLine("Printing grades via for loop");
for (int i = 0; i < grades.Count; i++)
{
    Console.WriteLine(grades[i]);
}

// Print vain the List - foreach loop
Console.WriteLine("Printing grades via foreach loop");
foreach (int g in grades)
{
    Console.WriteLine(g);
}