using System.Numerics;

namespace Interfaces;

internal class Program {

    static void Main(string[] args) {

        List<IProduct> products = new List<IProduct> {
            new Widget { ProductName = "Widget Silver", ProductPrice = 100.00m },
            new Widget { ProductName = "Widget Gold", ProductPrice = 500 },
            new Watch { ProductName = "Timex", ProductPrice = 35 },
            new Watch { ProductName = "Rolex", ProductPrice = 35000 },
            new Phone { ProductName = "iPhone", ProductPrice = 1000 },
            new Phone { ProductName = "Android", ProductPrice = 600 }
        };


        foreach(var product in products) {
            System.Console.WriteLine($"Product: {product.ProductName,-20}, Price: {product.ProductPrice:C}");
        }

    }
}
