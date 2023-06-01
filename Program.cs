

using ETprice.Entities;
using System.Globalization;

Console.Write("Enter the number of products: ");
int t=int.Parse(Console.ReadLine());


List<Product> products = new List<Product>();

for(int i = 0; i < t; i++)
{
    Console.WriteLine($"Product #{i+1} data: ");
    Console.Write("Common, used or imported (c/u/i)? ");
    string s = Console.ReadLine();

    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Price: ");
    double price=double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
    if ( s == "i")
    {
        Console.Write("Customs fee: ");
        double customsfee=double.Parse (Console.ReadLine(),CultureInfo.InvariantCulture);
        products.Add(new ImportedProduct(name, price, customsfee));

    }else if( s == "u")
    {

        Console.Write("Manufacture date (DD/MM/YYYY): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        products.Add(new UsedProduct(name, price, date));
    }
    else
    {
        products.Add(new Product(name, price));

    }
}

Console.WriteLine("PRICE TAGS: ");

foreach(Product product in products)
{
    Console.WriteLine(product.PriceTag());
}
