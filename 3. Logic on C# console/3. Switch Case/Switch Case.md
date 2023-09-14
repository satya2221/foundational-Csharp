There will be case where `if else` work just fine and easy to read and also maintain. However, there always be case where the `if-else if-else` was to much and it will be hard to read and maintain even tough it still work fine. In the latter scenario we can use switch case to help us maintain and read our code more easily.
## The Syntax
Switch case syntax in C# is similar with JS or C++ with this flow
`switch -> case -> break -> default`
```C#
string language = "French";
string greeting = "";

switch (language) {
  case "English":
    greeting = "Good Morning!";
    break;
  case "French":
    greeting = "Bonjour!";
    break;
  case "Japanese":
    greeting = "Ohayou Gozaimasu!";
    break;
  default:
    greeting = "Selamat Pagi!";
    break;
}

Console.WriteLine(greeting);

/* output
Bonjour!
*/
```
We can have a label for multiple case. What we need to do is not using break on the first case. The break is written on where the multiple case finish. Here is the example where `employeeLevel` 100 & 200 have same label
```C#
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
```
Any `employeeLevel` that is 100 or 200 will be have the same title that is `Senior Associate`.