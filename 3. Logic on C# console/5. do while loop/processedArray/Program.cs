// See https://aka.ms/new-console-template for more information
string[] myStrings = new string[2] { " I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
int periodLocation;
foreach (var item in myStrings)
{
    int start = 0;
    string myString = item;
    periodLocation = myString.IndexOf('.');
    while (periodLocation!=-1)
    {
        myString = myString.TrimStart(' ');
        Console.WriteLine(myString.Substring(0, periodLocation-1));
        myString = myString.Remove(start, periodLocation);
        periodLocation = myString.IndexOf('.');;
    }
    myString = myString.TrimStart(' ');
    Console.WriteLine(myString);

}
