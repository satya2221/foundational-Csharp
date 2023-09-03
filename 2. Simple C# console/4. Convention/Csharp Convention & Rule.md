In this part we will learn standard coding convention for C# so we can write a better code that easily readable and have more quality on it.

## Variable name
Naming a variable have to follow certain syntax rules and it should be make the code more human readable. Here is the rule of variable name
### Name rule
- Variable can contain alphanumeric char + underscore. `#` , `-`, and `$` are not allowed to use.
- Start with an alphabet or underscore, not a number
- Must not be aa C# keyword like data type name like `float`
- Variable are case sensitive so `MyValue` with `myValue` is 2 different variable
### Name convention
- Name should be **camel case** like this 
```C#
string thisIsCamelCase;
```
- name should be descriptive & meaningful by having what kind of data inside the variable. Instead of `bool isComplete` it would be better naming it `bool orderComplete`
```C#
// bool isComplete; Not a good way
bool orderComplete;
```
- Do not use abbreviation so instead of `decimal ordAmt` it would be better naming it `decimal orderAmount`
```C#
// decimal ordAmt; Not a good way
decimal orderAmount;
```
- Don't include the variable data type inside the variable name
## Comment
Comment in C# is called by using double slash `//`
```C#
// This is a code comment!
```
If we want to comment multiple line
```C#
/* The following code creates five random OrderIDs to test the fraud detection process. OrderIDs consist of a letter from A to E, and a three digit number. Ex. A123. */
```