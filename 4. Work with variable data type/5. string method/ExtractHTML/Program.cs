const string input = "<div><h2>Widgets &trade;</h2><span>5000</span></div>";

string quantity = "";
string output = "";

// Your work here
// quantity += "Quantity: ".PadRight(12);
// quantity += input.Substring(input.IndexOf("<span>") + 6, input.IndexOf("</span>") - input.IndexOf("<span>") - 6);

// output += "Output: ".PadRight(12);
// output += input.Remove(input.IndexOf("<div>"), 5);
// output = output.Remove(output.IndexOf("</div>"), 6);
// output = output.Replace("&trade;", "&reg;");

// Better Solution
quantity += "Quantity: ".PadRight(12);
int spanLength = "<span>".Length;
int spanStart = input.IndexOf("<span>") + spanLength;
int spanEnd = input.IndexOf("</span>");

quantity += input.Substring(spanStart, spanEnd - spanStart);

output += "Output: ".PadRight(12);
output += input.Remove(input.IndexOf("<div>"), "<div>".Length);
output = output.Remove(output.IndexOf("</div>"), "</div>".Length);
output = output.Replace("&trade;", "&reg;");

Console.WriteLine(quantity);
Console.WriteLine(output);