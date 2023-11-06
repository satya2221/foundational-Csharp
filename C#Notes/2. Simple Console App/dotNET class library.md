.NET class library is a collection of class containing a lot of method. One of the most common class library example is `Console` class that responsible for input & output operation like this
```C#
Console.WriteLine("Hello, world");
```
`Console` is just one of class library and there is many of them. Choosing the class that we need can be done by searching google or read dotnet documentation.
## How to call .NET class library
From this example
```C#
Console.WriteLine("Hello, world");
```
We can conclude how to call class library
1. Type the class name. In this case is  `Console`
2. Add the member access operator, the `.` symbol
3. Add the method name. In this case is `WriteLine`
4. Add the method invocation operator, which is a set of parentheses `()`
5. Fill the method argument inside those parentheses. In this example the argument is string that will be output
## Stateful vs Stateless method
**State** describe the condition of the execution environment at a specific moment. At any moment during execution, the current state of the application is the collection of all values stored in memory. Some method don't rely on the current state of the application, Others, rely on state. One thing for sure is one class can have both those method
### Stateless
This is a method that doesn't rely on the state of the application like `Console.WriteLine()`. `Console.WriteLine()` method doesn't rely on any values stored in memory. This method also known as **static method**
### Stateful 
Stateful method is direct opposite of stateless method. They rely on what really happen in the application during their execution. Stateful method keep track on their state in variable defined in the class. Stateful metho also known as **instance method**. One of the reason why its called instance method is because when you need to call stateful methods, you must first create an _instance_ of the class so that the method can access state.
## Creating Instance of Class
This is how you create instance of class in C#
```C#
Random dice = new Random();
```
To create new instance of class we use `use` operator that will do some of this thing
- It first requests an address in the computer's memory large enough to store a new object based on the `Random` class.
- It creates the new object, and stores it at the memory address.
- It returns the memory address so that it can be saved in the `dice` variable.
## Overloading
A lot of method in .NET have other version that mainly different in parameter that they accepted. This other version of a method with a same name under one class is called **overloading**.  Take a look at `.Next()` method below
```C#
Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}"); 
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
```
Here's what will happen based on their parameter
- `roll1` called `.Next()`method without any input parameter. Because of that, it will return values ranging from `0` to `2,147,483,647`, which is the maximum value an `int` can store
- `roll2` called `Next()` method with one parameter. Those parameter will be the upper limit that cannot be exceeded so the value will range from `0` to `100`
- `roll3` called `Next()` method with two parameter. First parameter will be the lower limit and the second parameter is the upper limit so the value will range from `50` to `100` 