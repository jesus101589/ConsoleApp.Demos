// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Initialize with a regular string literal.
string s1 = "This a string literal."; // preferred way to initialize a string, using lower case 'string'
String s2 = "This is another string literal.";

// Declare without initialization. (possible null exception)
string s3;

// Initialize to null. (possible null exception)
string? s4 = null;

// Initialize as an empty string.
string s5 = string.Empty; // "" (this is a safer way to initialize an empty string)
string s6 = "";

// Escape sequences and characters.
// She said, "I have your phone"
string sentence = "She said, \" I have your phone\" \r\n This is a new line.";

// Verbatim string literal.
string oldPath = "C:\\program Files\\programfolder\\"; //escaped backslash
string newPath = @"C:\program Files\programfolder\"; // verbatim string literal, no need to escape backslash


// Use a constant string to prevent modification to a string.
const string path = "C:\\program Files\\programfolder\\";
// path = "new value"; // This will cause a compile-time error, as constants cannot be modified.
s1 = "This is a new value"; // This is fine, as s1 is not a constant.

// Raw string literal.
string rawString = """
    This is a raw string literal.
    It can span multiple lines.
    No need to escape characters like " or \.
    """;

// Review concatenation and interpolation.
s1 = s1 + s2;
s1 += s2; // This is the same as the above line, but more concise.
string newString = $"{s1} {s2} Some random literal text"; // String interpolation, preferred way to concatenate strings in C#.
string newString1 = s1 + $"{s1} {s2} Some random literal text"; // Concatenation using the + operator, but not preferred for readability and performance reasons.
string newString2 = String.Format("Literal string {0} {1}", s1, s2); // String.Format is less preferred than interpolation but still valid.