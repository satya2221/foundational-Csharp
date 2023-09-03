// See https://aka.ms/new-console-template for more information
// string[] fraudulentOrderIDs = new string[3];
string[] fraudulentOrderIDs =  {"A123" ,"B123","C234", "A345", "C15","B177","B179", "B456", "C789"};
fraudulentOrderIDs[0] = "F000";

int bin = 1;
int fraudCounter = 0;
foreach (var item in fraudulentOrderIDs)
{
    if(item.StartsWith("B"))
    {
         Console.WriteLine($"Id{bin}: {item}");
         fraudCounter ++;
    }

    bin++;
}

Console.WriteLine($"There are {fraudCounter} fraudulent from {fraudulentOrderIDs.Length} orders to process.");


