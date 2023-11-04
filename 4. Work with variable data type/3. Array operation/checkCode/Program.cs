// See https://aka.ms/new-console-template for more information
string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
string[] codes = orderStream.Split(',');
foreach (string code in codes)
{
    int codeLength = code.Length;
    if (codeLength != 4)
        Console.WriteLine(code + "\t -Error");
    else
        Console.WriteLine(code);
}
