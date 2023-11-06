Code block has many purpose on many programming language including C#.  The most common purpose of code block is in **Selection** (If and switch case) and **iteration** (for, foreach, etc.) where code blocks use to group together code line that should be executed, skipped, or iterated over. Other than that, code block can be useful for control or limiting variable accessibility and scope inside the program. The boundaries of a code block are typically defined by squiggly braces, `{}`
Here is code block in action
## Impacting the scope of variable
Here is the example how code block impacting variable inside our program
```C#
bool flag = true;
if (flag)
{
    int value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine($"Outside of code block: {value}");
```
The last line of code will throw an **error** because `value` variable only define and work inside the `if` code block.  This line of code will fix the error by defining `value` outside the `if` code block
```C#
bool flag = true;
int value = 0;

if (flag)
{
    value = 10;
    Console.WriteLine("Inside of code block: " + value);
}
Console.WriteLine("Outside of code block: " + value);
```
The output from the code above will be
```
Inside of code block: 10
Outside of code block: 10
```

## Simplify if statement by removing code block
If a statement only need one line of code, we can simplify it by not using curly braces. Here is the example of `if` statement with only one line of code
```C#
bool flag = true;
if (flag)
{
    Console.WriteLine(flag);
}
```
We can simplify it become like this
```C#
bool flag = true;
if (flag)
    Console.WriteLine(flag);
```
The code above is the best practice when we want to simplify a statement with one line of code (Enter it to one line and indent it). The code below will works the same too but it will reduce the readability
```C#
// Do not code like this ❌ ❌ ❌ ❌ 
string name = "steve";
if (name == "bob") Console.WriteLine("Found Bob");
else if (name == "steve") Console.WriteLine("Found Steve");
else Console.WriteLine("Found Chuck");
```