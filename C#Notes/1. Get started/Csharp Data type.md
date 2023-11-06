Some of the data type that needs to be attention in C#
## Working with number
- For integral numeric data type like `uint`, `long`, `int`, etc, could be check [here](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
- The one that need attention is floating point numeric type that have 3 keyword (`float`, `double`, `decimal`).  The implementation of those 3 keyword is as following
```C#
// double
double a = 12.3; // double a = 12.3d will also work (with ~15-17 digits of precision)

//float
float b = 12.12f; // (with ~6-9 digits of precision)

//decimal
decimal c = 13.776m; // (with 28-29 digits of precision)
```
- For `float` & `decimal` we need to give literal suffix after the number. For the `float` the suffix will be `f` or `F` while for the `decimal` the suffix will be `m` or `M`.
- We can directly operate `floating` point number with `integral` number. The `integral` number will be converted automatically  like this
```C#
var x = 2.3;
int y = 2

var total = x+y;
Console.WriteLine(total); // Output will be 4.3 with total type will be double
```
- We still can operate `float` & `double` like this
```C#
var x = 1.9f;
var y = 2.11;

var total = x + y;

Console.WriteLine(total.GetType()); //wil be double

Console.WriteLine(total); // output 4.00999997615814
```
- Problem occur when we want to operate `decimal` data type with `float` or `double`. Cast / convert must be happen either to `decimal` or go to `float` / `double`
```C#
double a = 1.0;
decimal b = 2.1m;

Console.WriteLine(a + (double)b);
Console.WriteLine((decimal)a + b);
```
- Read more about floating point number [here](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#code-try-1)
## Value vs Reference Type
- Reference type store reference to their data (we store the data inside our object)
- Value type store their data directly inside the variable
### Reference Type
In C# reference type including array, class, and strings. Unlike *value type* that saved inside area of storage that called **stack** (memory allocated for the code that currently run on CPU) that will be vanished after it was finish executing, *reference type* will be saved inside **heap** (memory that shared across many application) so it will work like pointer in golang that will return the memory address of the variable.
Reference type is characterized by the use of `new` clause by the time we make variable. Here is the example of making new array
```C#
int[] data;
data = new int[3];
```
## Integral Type
Beside basic `int` there is other integral type like
- `sbyte` range between -128 to 127
- `short` range between -32768 to 32767
- `int` range between -2147483648 to 2147483647
- `long` range between -9223372036854775808 to 9223372036854775807
We can find this range using `MinValue` and `MaxValue` method 
```C#
Console.WriteLine("Signed integral types:"); 
Console.WriteLine($"sbyte : {sbyte.MinValue} to {sbyte.MaxValue}");
Console.WriteLine($"short : {short.MinValue} to {short.MaxValue}");
Console.WriteLine($"int : {int.MinValue} to {int.MaxValue}"); 
Console.WriteLine($"long : {long.MinValue} to {long.MaxValue}");
```
To represent only positive number we can use unsigned integer
- `byte`
- `ushort`
- `uint`
- `ulong`
