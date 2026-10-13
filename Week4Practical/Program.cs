
// challenge 1 
using System.ComponentModel.Design;
using System.Runtime.CompilerServices;
using Week4Practical;

string[] carManufacturers = ["Ford", "Toyota", "BMW", "Honda"];



foreach (var brand in carManufacturers)
{
    Console.WriteLine(brand);
    Array.Sort(carManufacturers);
}
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
// challenge 2
List<string> months = new List<string> { };
months.Add("January");
months.Add("February");
months.Add("March");
months.Add("April");
months.Add("May");
months.Add("June");
months.Add("July");
months.Add("August");
months.Add("September");
months.Add("October");
months.Add("November");
months.Add("December");

months.Remove("September");
months.Remove("November");

foreach (string month in months)
{
    Console.WriteLine(month);
}

Console.WriteLine(months.Count);

Console.WriteLine(months.IndexOf("December"));

months.ToArray();
Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");
//challenge 3
Dictionary<string, int> Inventory = new Dictionary<string, int>();

Inventory.Add("Health Potion", 5);
Inventory.Add("Mana Potion", 2);
Inventory.Add("Gold Coin", 100);

Inventory["Health Potion"] = 20;

foreach (KeyValuePair<string, int> item in Inventory)
{
    Console.WriteLine($"{item.Key}: {item.Value}");
}
    //Console.WriteLine(Inventory["Iron Sword"]);

Console.WriteLine("-----------------------------------------------------------------------------------------------------------------------");

//challenge 5





