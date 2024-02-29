string str1 = "Hello, World!";
string str2 = "Hello, World!";

// Check if the two strings reference the same object in memory
Console.WriteLine(object.ReferenceEquals(str1, str2)); // True

Console.WriteLine($"0x{str1.GetHashCode():X8}"); // 0xEFD7DFBF
Console.WriteLine($"0x{str2.GetHashCode():X8}"); // 0xEFD7DFBF


// Modify one of the strings
str1 = str1.ToUpper();

// Now, the strings are no longer reference-equal because str1 is a new string
Console.WriteLine(object.ReferenceEquals(str1, str2)); // False

Console.WriteLine($"0x{str1.GetHashCode():X8}"); // 0x1B29DC09
Console.WriteLine($"0x{str2.GetHashCode():X8}"); // 0xEFD7DFBF