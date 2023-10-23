Some of the data type that needs to be attention in C#
## Working with number
- For integral numeric data type like `uint`, `long`, `int`, etc, could be check [here](https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types)
- The one that need attention is floating point numeric type that have 3 keyword (`float`, `double`, `decimal`).  The implementation of those 3 keyword is as following
```C#
// double
double a = 12.3; // double a = 12.3d will also work

//float
float b = 12.12f;

//decimal
decimal c = 13.776m;
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
