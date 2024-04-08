double total = 0;
double minimumSpend = 30.00;

double[] itemsPrice = {15.97, 3.50, 12.25, 22.99, 10.98};
double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

for (int i = 0; i < itemsPrice.Length; i++)
{
    total += GetDiscountedPrice(i);
}

Console.WriteLine($"Total With discount: {total}");

total -= TotalMeetsMinimum() ? 5.00 : 0;

Console.WriteLine($"Final Total: {FormatDecimal(total)}");

double GetDiscountedPrice (int itemIndex)
{
    double finalPrice = itemsPrice[itemIndex] - (itemsPrice[itemIndex]*discounts[itemIndex]);
    return finalPrice;
}

bool TotalMeetsMinimum()
{
    return total >= minimumSpend;
}
string FormatDecimal(double input)
{
    return input.ToString().Substring(0, 5); //Make sure only display 2 decimal places
}