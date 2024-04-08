Method in C# is similar to most programming language especially C base like C++ or C. Here is the format of a method in C#
```C#
void SayHello(){
	Console.WriteLine("Well, Hello there");
}
```
From the example above we can conclude
- In the example the method doesn't return a thing so it is using void clause. If we want the method to return any data type we can change it to `int`, `bool`, `double`, etc. 
- The method name in the example already following the C# name convention for method where 
	- It used clear concise of what action this method do
	- Written in `PascalCase` and not start with a number
- There is method definition that put inside the curly braces `{}` that we call method signature
## Method with Parameter
Method can have a **parameter** that can filled by an **argument**. This has to be done when we want to provide some information to the method. Here is the example
```C#
void DisplayAdjustedItems (int[] times, int currentGMT, int newGMT)
{
	if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12) 
	{ 
		Console.WriteLine("Invalid GMT"); 
	}
}
```
### Working with Reference & Value Type
Parameter of reference type and value type has different behavior like this
- In **Value Type** when an argument passed to the parameter of the method, the *value of the variable will be copied* to the method so if the change happen it become local variable inside the method
- In **Reference Type**, the value of the address of the variable will be copied to the method. This will make any change inside the method will affect the variable globally. 
- One exception is in **string**. String is a reference type that behave like value type because the *immutable* status
- Example of **Value** Type. In this example, c in global stay 0 even though in *Multiple* function the value already change
```C#
int a = 3;
int b = 4;
int c = 0;
Mulitply(a, b, c);
Console.WriteLine($"Result Global: {a} x {b} = {c}");

void Mulitply (int a, int b, int c)
{
	c = a * b;
	Console.WriteLine($"Result Inside Function: {a} x {b} = {c}");
}

// Output will be
// Result Inside Function: 3 x 4 = 12
// Result Global: 3 x 4 = 0
```
- Example of **Reference** Type. In this example, *myArray* variable is a reference type so when we execute *Clear* function, every value will be change to 0 because *Clear* function have the address of *myArray* variable
```C#
int[] myArray = {1,2,3,4,5};

PrintArray(myArray);
Clear(myArray);
PrintArray(myArray);

void PrintArray(int[] arrayParam)
{
	foreach(int val in arrayParam)
	{
		Console.Write($"{val} ");
	}
	Console.WriteLine();
}

void Clear(int[] arrayParam)
{
	for (int i = 0; i < array.Length; i++) 
	{ 
		array[i] = 0; 
	}
}

// Output will be
// 1 2 3 4 5
// 0 0 0 0 0
```
- Example of **string**. Even though *healthStatus* is a string that is **Reference** type, the original value of *healthStatus* only change inside the function only
```C#
string healthStatus = "Healthy";

Console.WriteLine($"Start status: {healthStatus}");
SetHealth(false)
Console.WriteLine($"End status: {healthStatus}");

void SetHealth(bool isHealthy)
{
	healthStatus = (isHealthy ? "Healthy": "Unhealthy");
	Console.WriteLine($"Inside Function status: {healthStatus}");
}

// Output will be
// Start status: Healthy
// Inside Function status: Unhealthy
// End status: Healthy
```
## Method with Return Value
Method can return a value so if it combine with parameter, it can create a streamline where there is an input that will be process inside a function and then become an output in the form of the **return value**. 
In fact, **return type** must always specified before the method name. However, we doesn't return a value at all so we use *void* as the return type like this
```C#
void Mulitply (int a, int b, int c)
{
	c = a * b;
	Console.WriteLine($"Result Inside Function: {a} x {b} = {c}");
}
```
If we want our function to return an *double* and then use it on variable we can do something like this
```C#
double GetDiscount(double amount, double discount)
{
	return amount * (1 - discount);
}

double total = GetDiscount(25000, 0.25);
```