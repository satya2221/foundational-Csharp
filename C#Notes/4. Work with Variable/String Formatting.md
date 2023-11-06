## Composite Formatting
The most basic string formatting in C# is run using `Format()` method from String class. Here is the implementation of `Format()` method
```C#
string first = "Hello";
string second = "World"; 
string result = String.Format("{0}, {1}", first, second);
Console.WriteLine(result); //Output Hello, World
```
The number inside the curly braces indicate the position will be taken from `Format()` parameter after the string format. Because of that, if we switch the 1 and 0 in the code above with the same parameter position, it will become `World, Hello`
```C#
// Switch result format
string result = String.Format("{1}, {0}", first, second);
Console.WriteLine(result); //Output World, Hello
```
Anyway, we can directly use this `Format()` method inside the `WriteLine()` method like this
```C#
string first = "Hello";
string second = "World";
Console.WriteLine("{1} {0}!", first, second); // Output World Hello!
Console.WriteLine("{0} {0} {0}!", first, second); //Output Hello Hello Hello!
```
## String Interpolation
The composite formatting is easily understand and readable if we only pass 2-3 variable that will be formatted. More than that, it will become complex and will not be easily to read and maintenance. String interpolation comes to fix the composite formatting problem by directly pass the variable into the string format. Here is how to use string interpolation
```C#
string first = "Hello";
string second = "World";
Console.WriteLine($"{first} {second}!"); // Output Hello World!
Console.WriteLine($"{second} {first}!"); // Output World Hello!
Console.WriteLine($"{first} {first} {first}!"); //Output Hello Hello Hello!
```
## Further Formatting
We can give instruction how we want to format our data Inside our string interpolation or composite formatting. This is achievable using this `:<Formar code><Number of precision>`. There are some code of format code 
### Currency
If we want to format our variable as currency inside our string formatting, we can use `:C` inside our formatting. Here is how
```C#
decimal price = 123.45678m;
int discount = 50;
Console.WriteLine($"Price: {price:C} (Save {discount:C})");
// Output Price: ¤123.46 (Save ¤50.00)
```
Two things that we need to noted from the output
> -  If we didn't include precision number, by default it will round up to 2 digits after decimal point
> - The symbol of currency will dependent on our pc country, region, and language setting
### Number
We use `:N` to format our string into more readable number. Here is the example with precision 4 digits after decimal point
```C#
decimal measurement = 123456.78918m; 
Console.WriteLine($"Measurement: {measurement:N4} units");
// Output Measurement: 123,456.7892 units
```
### Percentage
We can use `:P` to format our number into percentage format in string. With this format our number will multiply by 100 then add percentage symbol in the back Here is the example 
```C#
decimal tax = .36785m;
Console.WriteLine($"Tax rate: {tax:P3}"); // Output Tax rate: 36.785 %
```
## Padding & Alignment
We can add a white space to our console using `PadLeft` or `PadRight`. Here is the example
```C#
string input = "Pad this";
Console.WriteLine(input.PadLeft(12));
// Output:    Pad this
```
There are 4 whitespace in the right or before our string. This 12 character inside the `PadRight` translated into 4 empty white space. We can pad it with some character like `-`. Here is how
```C#
string input = "Pad this";
Console.WriteLine(input.PadLeft(12,'-'));
// Output:----Pad this
```
## IndexOf
This string method is used for locating character within the string. Supposed that we want to locate parenthesis inisde our string, here is how
```C#
string message = "Find what is (inside the parentheses)";
int openings = message.IndexOf('(');
int closings = message.IndexOf(')');
Console.WriteLine(openings); // 13
Console.WriteLine(closings); // 36
```
From the code above, we can take few points
- In the example, we search for a parenthesis character `(`. Not only character, we can also search a string using this `IndexOf()` method just change to double quote if we want to search string
- It will only return one index value. This value is the first appearance of what we want to search.
- The index start from 0 not from 1
## Substring
`Substring()` method can be combined with `IndexOf()` method to take string between some character or string. It is because `Substring()` will take substring from certain index with a length that we determined. Here is the example of combining `Substring()` with `IndexOf()`
```C#
string message = "Find what is (inside the parentheses)";
int openings = message.IndexOf('(');
int closings = message.IndexOf(')');

int length = closings - openings;
Console.WriteLine(Substring(openings+1, length)); 
// Output: inside the parentheses
```
From the code above, we can take a few points
- `Substring()` in this example take 2 argument. First argument is the start position and the second argument is the length. `Substring()` also has other method (overload method) that only accept one argument that is the start of the substring. Because of that, the length will be from the start index until the end of the string
- In this example we need to +1 to the openings because it is indicate the start of the substring. If we didn't do +1 operation, the parenthesis will be included in the substring
## LastIndexOf
`LastIndexOf()` method is work like `IndexOf()` method. However, `LastIndexOf()` will return the index of the last occurrence of the searched char/string. So, if there is multiple occurrence of searched char/string, `IndexOf()` will return index of the first occurrence that founded while `LastIndexOf()` will return index of the last occurrence. Here is the example
```C#
string message = "(What if) I am (only interested) in the last (set of parentheses)?";
int openingPosition = message.LastIndexOf('('); 
openingPosition += 1; 

int closingPosition = message.LastIndexOf(')'); 
int length = closingPosition - openingPosition; 

Console.WriteLine(message.Substring(openingPosition, length));
// Output: set of parentheses
```
There is 3 occurrence both opening and closing parentheses in the example above. `LastIndexOf()` take the last one
## IndexOfAny
If we want to search multiple occurrence of character we can use `IndexOfAny()` method. `IndexOfAny()` will need **array of char** to be one of the parameter. Then, `IndexOfAny()` will return the very first index of the any character inside the array. Here is the example
```C#
string message = "Help (find) the {opening symbols}";
char[] openSymbols = { '[', '{', '(' };
int openingPosition = message.IndexOfAny(openSymbols); Console.WriteLine($"Found WITHOUT using startPosition: {message.Substring(openingPosition)}");

//Output (find) the {opening symbols}
```
## Remove
As the name implies, this method will remove part of the string. It work similarly like `Substring()` until it has 2 form just like `Substring()` method. However, `Remove()` will removing the subsbtring instead of save the substring like `Substring()`method.
```C#
string data = "12345John Smith          5000  3  ";
string updatedData = data.Remove(9, 16);
Console.WriteLine(updatedData); // Output 12345John5000 3
```
## Replace
As the name implies, this method will replace substring or character with a new substring or character. Here is the example
```C#
string message = "This--is--ex-amp-le--da-ta"; 
message = message.Replace("--", " "); 
message = message.Replace("-", ""); 
Console.WriteLine(message);// Output This is example data
```
From the code above we can see that it will replace any occurrence with its desire target.