Array is a reference type in C# that has many helper method to perform the operation in array. 
## Sort & Reverse
This is the simplest method that will sort an array. `Sort()` method is used for sorting array ascendingly while `Reverse()` is used for sorting array in descending manner. Here is the example of this 2 method in action
```C#
string[] pallets = { "B14", "A11", "B12", "A13" }; 
Console.WriteLine("Sorted..."); Array.Sort(pallets); 
foreach (var pallet in pallets) 
{ 
	Console.WriteLine($"-- {pallet}"); 
} 
Console.WriteLine(""); 
Console.WriteLine("Reversed..."); 
Array.Reverse(pallets); 
foreach (var pallet in pallets) 
{ 
	Console.WriteLine($"-- {pallet}"); 
}
```
## Clear & Resize
Both clear & resize method will be useful for removing element or adding element to array
### Clear
This method will *clear* or make the targeted array index will be empty. So, in this method we just make the index empty but the length of the array is still the same. Here is the example
```C#
string[] pallets = { "B14", "A11", "B12", "A13" };
Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
// Output
//Clearing 2 ... count: 4
//--
//--
//-- B12
//-- A13
```
index 0 and 1 element is null but represented inside the console as empty string. If we try to operated it using any string method like `ToLower()` it will throw an error. 
### Resize 
This method will be resizing the array to the desire size. With this method we can make the array bigger or even removing element by making the array smaller than the original size. Here is the example where we make the array bigger from the example above
```C#
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}"); 
pallets[4] = "C01"; 
pallets[5] = "C02"; 
foreach (var pallet in pallets) 
{ 
	Console.WriteLine($"-- {pallet}"); 
}
```
## ToCharArray()
This method is used to split string into array of char. Like in this example
```C#
string value = "abc123";
char[] valueArray = value.ToCharArray();

Console.WriteLine(valueArray);
```
With this we can reverse our string by using array `Reverse()` method than we convert it back to string by initiate a new string object. Here is the execution
```C#
// Change the string to array
string value = "abc123";
char[] valueArray = value.ToCharArray();

//Reverse sort the array
Array.Reverse(valueArray);

// Make the array back to string
string result = new String(valueArray);
```
## Join()
Beside reversing our input string, we can separated character from our string using symbol like comma or dash. That operation can be done by string `Join()` method. Here is the example we separated the char inside our string with a comma
```C#
// Change string to array
string value = "abc123";
char[] valueArray = value.ToCharArray();

// separated every char with comma
string result = String.Join(",", valueArray);
Console.WriteLine(result); // The output wil be a,b,c,1,2,3
```
## Split()
`Split()` string method is the reverse operation of join. It's because this method will breakdown (split) string into an array by checking the delimiter (separated char) inside the string. Let's use the example from join. The result string will be made into array again using `Split()`
```C#
// Change string to array
string value = "abc123";
char[] valueArray = value.ToCharArray();

// separated every char with comma
string result = String.Join(",", valueArray);

// Make result back to string
string[] items = result.Split(',');
```