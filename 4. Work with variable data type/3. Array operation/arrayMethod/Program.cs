string[] pallets = { "B14", "A11", "B12", "A13" };

Array.Clear(pallets, 0, 2);
Console.WriteLine($"Clearing 2 ... count: {pallets.Length}");
foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("");
Array.Resize(ref pallets, 6);
Console.WriteLine($"Resizing 6 ... count: {pallets.Length}");

pallets[4] = "C01";
pallets[5] = "C02";

foreach (var pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
Console.WriteLine("Unsorted");
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();

Console.WriteLine("Sorted");
Array.Sort(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}

Console.WriteLine();

Console.WriteLine("Reverse Sorted");
Array.Reverse(pallets);
foreach (string pallet in pallets)
{
    Console.WriteLine($"-- {pallet}");
}
string value = "abc123";
char[] valueArray = value.ToCharArray();

Console.WriteLine(valueArray);