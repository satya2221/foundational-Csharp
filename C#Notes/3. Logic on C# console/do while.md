`do while` is a another version of `while` that make sure the loop will run at least once before it stop. `do while` in C# is similar to C++ or JS. Here is an example of `do while` when we want to print number from `random.Next()` method
```C#
Random randomNumber = new Random();
int current = randomNumber.Next(1,11);

do{
	Console.WriteLine(current);
	current = randomNumber.Next(1,11);
}while (current != 7) ;
```
The code above make sure any random number including seven will at least print once. If we using only `while` loop on the case above, if the first random number output is seven, it will not print or do anything. 
## continue statement
If we want to skip an iteration on `do while` loop, we use `continue` statement inside the loop. Here is the example of code above where we skip any number larger than 8
```C#
Random randomNumber = new Random();
int current = 0;

do{
	current = randomNumber.Next(1,11);
	if (current > 8)
		continue; // skip number larger than 8 but doesn
	Console.WriteLine(current);
}while (current != 7) ;
```
If the `continue` statement executed, it will skip any other code inside the do and straightforward to check `while` condition . In the example above if the number large than 8, it will not be printed because it directly goes to check the `while` condition.
## Managing User Input
We can use `Console.ReadLine()` statement to obtain user input. Because of that, in C# is a common practice to use nullable string (declare as `string?`). This string will be filled by the user input. Here is the example of `string?` combine with `do while` to check if the user input string with 3 or more character.
```C#
string? readResult;
bool validEntry = false;
Console.WriteLine("Enter string with at least 3 character");
do{
	readResult = Console.ReadLine();
	if (readResult!=null){
		if(readResult.Length >= 3)
			validEntry = true;
		else
			Console.WriteLine("Your input is invalid, please try again.");
	}
}while (validEntry == false);
```
`Console.ReadLine()` accept any input as a string. So, any numeric input must be convert it first. If we just want to convert it we can use `int.Parse()` method. However, if the input is not numeric or can't be convert, it will throw an exception and if it's not catch properly means it will stop the program completely. Another method is `int.TryParse()`. Unlike `int.Parse()`, `int.TryParse()` will return `true` if the convert operation is success and will return `false` if the convert operation is failed. Lot of time those 2 method will be use simultaneously like in this example
```C#
string? readResult;
int numericValue  = 0;
readResult = Console.ReadLine();
if (int.TryParse(readResult, out numericValue))
	numericValue = int.Parse(readResult);
else
	Console.WriteLine("Your input is not an integer");
```

