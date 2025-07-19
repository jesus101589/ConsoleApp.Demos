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