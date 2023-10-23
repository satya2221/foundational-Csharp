## Declaring Array
C# has its own way to declare array, Here is how to declare empty string array with 3 element
```C#
string[] fraudulentOrderIDs = new string[3];
```
Assigning value and how to retrieve an array is similar to C++. Here is some example
```C#
string[] fraudulentOrderIDs = new string[3];

// Assign Value
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// retrieve / access value
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");
```
## Initialize Array
We can directly initialize array without declaring it first. Here is how to declare string array
```C#
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };
```
If we initialize it first, to know how many element inside the array we can use `Length` property
```C#
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders");
```
## Using `foreach`
We can loop through array using `foreach` statements. Here is how we can do it
```C#
string[] names = { "Rowena", "Robin", "Bao" };
foreach (string name in names)
{
    Console.WriteLine(name);
}
```
With this `foreach` we can search sum of the integer array like this
```C#
int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}
```