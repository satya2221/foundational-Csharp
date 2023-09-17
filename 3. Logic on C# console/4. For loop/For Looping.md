`for `Looping in C# has similarity with looping in many programming language like C++ or JavaScript with this format
```C#
for (int i = 0; i < 10; i++) 
{ 
	Console.WriteLine(i); 
}
```
We can exit the loop on certain condition using `break` clause. In the example above we want to stop the iteration when `i` is 7
```C#
for (int i = 0; i < 10; i++) 
{ 
	Console.WriteLine(i); 
	if (i==7)
		break;
}
```
`for` loop also can be used to overcome limitation that come using `foreach` when iterating an array. `foreach` loop doesn't allow us change the value inside an array. Here we have example using `foreach` and `for` loop
```C#
// Using foreach
string[] names = { "Alex", "Eddie", "David", "Michael" }; 
foreach (var name in names) 
{ 
	if (name == "David") name = "Sammy"; 
}

// Will thrown an error
```
The example above will return an error. So, we use normal `for` to accomodate those problem
```C#
string[] names = { "Alex", "Eddie", "David", "Michael" }; 
for (int i = 0; i < names.Length; i++) 
	if (names[i] == "David") names[i] = "Sammy"; 
	
foreach (var name in names) Console.WriteLine(name);
```