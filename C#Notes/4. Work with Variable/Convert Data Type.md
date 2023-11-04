In C# there are multiple technique to perform a data type conversion depending on the case that we want to do. C# itself can automatically make a safe conversion in some cases.
## Compilers make safe conversion
This line of code will not produce an error
```C#
int first = 2;
string second = "4";
string result = first + second;
Console.WriteLine(result); // The output will be 24
```
However, this line of code will produce an error
```C#
int first = 2;
string second = "4";
int result = first + second;
Console.WriteLine(result); // Will throw an error
```
That is happening because C# make a *safe conversion* when converting `int` to `string` because if the value of the 2 variable change the result concatenation operation still possible to happen by converting the `int` to `string` than in the `result` variable, both is concatenated. However, C# compiler can't convert `string` to `int` because the value of `string` variable can be changed to something that is not `int` like "hello world".
This safe conversion can also happen on when converting data type with less information to data type with more information. Here is example when we convert `int` to `decimal`.
```C#
int myInt = 3; 
Console.WriteLine($"int: {myInt}"); 

decimal myDecimal = myInt; 
Console.WriteLine($"decimal: {myDecimal}");
```
The operation above was fine and called *widening conversion*, attempting to convert a value **from** a data type that could hold _less_ information **to** a data type that can hold more information. Because of this type of conversion doesn't lose any information C# compiler can do **implicit conversion**.
## Perform a Cast
Casting is needed when we do the opposite of *widening conversion*, *narrowing conversion*. *Narrowing conversion* is when we convert value from data type that hold more information to a data type that held less information. Here is the example of *narrowing conversion* when we want to convert `decimal` to `int`
```C#
decimal myDecimal = 3.14m; 
Console.WriteLine($"decimal: {myDecimal}"); // decimal: 3.14

int myInt = (int)myDecimal; 
Console.WriteLine($"int: {myInt}"); // int: 3
```
Casting instruction is basically happen in `(int)myDecimal`. Casting basically instruction to the compiler that we ok to lose some information when we do conversion so it was called **explicit conversion**
## Other Data Conversion
Beside **implicit** and **explicit** conversion, we can do conversion with the help of these 3 technique
### Using helper method on variable
One of the example of this technique is `ToString()` method. Every datatype variable has this `ToString()`method that will help convert any datatype to `string`. Here is the example
```C#
int first = 5; 
int second = 7; 
string message = first.ToString() + second.ToString(); 
Console.WriteLine(message); // Output 57
```
### Using helper method on datatype
Most of numeric data type have `Parse()` method that can help converting string to numeric datatype. Here is the example
```C#
string first = "5"; 
string second = "7"; 
string message = int.Parse(first) + int.Parse(second); 
Console.WriteLine(message); // Output 12
```
### Using Convert class
The `Convert` has many helper method to convert datatype. In this example we use `ToInt32()` method to convert `string` to `int`
```C#
string first = "5";
string second  = "7";
int message = Convert.ToInt32(first) * Convert.ToInt32(second);
Console.WriteLine(message); // Output 35
```
`ToInt32()` has 19 other overload method so its not just string that can be converted to integer using this method.
## Convert vs Cast
When we do narrowing conversion, there is difference between **convert** & **cast**. The main different converting using `Convert` class then using casting operation is the accuration. It's because convert will round the number to the nearest integer number while casting is truncating the number. Here is the example
```C#
int value = (int)1.5m; // casting truncates
Console.WriteLine(value); // Output 1

int value2 = Convert.ToInt32(1.5m); // converting rounds up 
Console.WriteLine(value2); // Output 2
```
## Using TryParse()
When we use `Parse()` method, if the conversion is failed, it will throw an error that will stop the program if it's not handled. Because of that, conversion is saver using `TryParse()` method. If the conversion failed, `TryParse()` will return false. If it successfull it will return true. Because of that, `TryParse()` method used in if else scenario like this
```C#
string value ="102";
int result  = 0;
if(int.TryParse(value, out result))
	Console.WriteLine($"Conversion result is: {result}");
else
	Console.WriteLine("Unable to convert the string")
```