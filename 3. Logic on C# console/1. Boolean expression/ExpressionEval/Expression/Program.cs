Console.WriteLine("First Example");
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

Console.WriteLine("\nSecond Example");
string myValue = "a";
Console.WriteLine(myValue == "a");

Console.WriteLine("\nThird Example using Trim and ToLower");
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

Console.WriteLine("\nFourth Example using Method that returns a bool");
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

