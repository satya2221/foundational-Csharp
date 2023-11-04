// int value = (int)1.5m; // casting truncates
// Console.WriteLine($"value using casting is {value}"); // Output 1

// int value2 = Convert.ToInt32(1.5m); // converting rounds up 
// Console.WriteLine($"value using convert is {value2}"); // Output 2

string[] values = { "12.3", "45", "ABC", "11", "DEF" };
decimal total = 0;
string message = "";

foreach (var item in values)
{
    if (decimal.TryParse(item, out decimal result))
    {
        total += result;
    }
    else
    {
        message += item;
    }
}
Console.WriteLine($"Message: {message}"); // Output ABCDEF
Console.WriteLine($"Total: {total}"); // Output 68

int value1 = 12;
decimal value2 = 6.2m;
float value3 = 4.3f;

int result1 = value1 / Convert.ToInt32(value2);
decimal result2 = value2 / (decimal)value3;//decimal result2 = value2 / Convert.ToDecimal(value3);
float result3 = value3 / value1; //float result3 = value3 / Convert.ToSingle(value1);

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");
