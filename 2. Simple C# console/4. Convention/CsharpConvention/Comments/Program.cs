/*
  The following code creates five random OrderIDs
  to test the fraud detection process.  OrderIDs 
  consist of a letter from A to E, and a three
  digit number. Ex. A123.
*/
Random random = new Random();
string[] orderIDs = new string[5];

for (int i = 0; i < orderIDs.Length; i++)
{
    int prefixValue = random.Next(65, 70);
    string prefix = Convert.ToChar(prefixValue).ToString();
    string suffix = random.Next(1, 1000).ToString("000");

    orderIDs[i] = prefix + suffix;
}

foreach (var orderID in orderIDs)
{
    Console.WriteLine(orderID);
}
Console.WriteLine("Finish comment continue to fix case");

// reverse a string and count the number of times 
// a particular character appears.

string originalMessage = "The quick brown fox jumps over the lazy dog.";

// convert the message into a char array
char[] charMessage = originalMessage.ToCharArray();

// Reverse the chars
Array.Reverse(charMessage);

// count the o's
int letterOCount = 0;
foreach (char i in charMessage) 
{ 
    if (i == 'o') 
        letterOCount++; 
}

// convert it back to a string
string new_message = new String(charMessage);

// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterOCount} times.");