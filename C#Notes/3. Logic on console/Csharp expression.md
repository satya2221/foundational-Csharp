 *Expression* is combination of value (literal / variable), operator, and methods that return a single value. A *statement* is a complete C# instruction that composed of one or more expression. Take a look to this `if` statement example
```C#
if(myName == "Satya")
	...
```
In those `if` statement, expression that return `true` or `false` is used. Expression that return `true` or `false` is Boolean expression. In those example, the Boolean expression using equality operator (`=`) that will check whether the value of `myName` variable equal to the value on the right. If equal then return `true` and if not return `false`. Opposite of equal operator is inequality operator (`!=`) .
## Equality Operator Use case
When handling user input there will be probably case like this
```C#
Console.WriteLine("a" == " a");
Console.WriteLine("a" == "A ");
```
Even tough it compare letter `a`, both will return `false` because there is space in the first line and in the second line. Then in second line its an `A` not `a` so even the space is deleted it will keep return `false`. The solution to those problem is
- To make sure no blank space, we can use `Trim()` helper method that will remove any leading or trailing blank space.
- To make sure the string is in the same upper or lower case we use `ToUpper()` or `ToLower()` helper method to the string value
With that 2 helper method, this line of code will return `true`
```C#
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower()); // output True
```
## Conditional operator
Compact format of `if ... else`. The basic form is like this
```C#
<evaluate this condition> ? <if condition is true> : <if condition is false>
```
Here is example to determine discount
```C#
int saleAmount = 1001; 
int discount = saleAmount > 1000 ? 100 : 50; 
Console.WriteLine($"Discount: {discount}"); //Output will be 100
```