using System;

class Program
{
    static void Main(string[] args)
    {
        Address address1 = new Address("Cool Main Street", "Rexburg", "ID", "USA");
        Customer customer1 = new Customer("Jerry Spaghetti", address1);
        List<Product> products1 = new List<Product>
        {
            new Product("Meat Balls", 234729834, 9.99m, 12),
            new Product("Spagetti", 238989898, 1.99m, 20)
        };
        Order order1 = new Order(products1, customer1);

        Address address2 = new Address("1917 E Red Barn Road", "Springville", "UT", "USA");
        Customer customer2 = new Customer("Owen Rowe", address2);
        List<Product> products2 = new List<Product>
        {
            new Product("Starwars Legos", 12232323, 79.99m, 1),
            new Product("Lord of the Rings Legos", 1444422323, 89.99m, 1),
            new Product("Jurrassic Park Legos", 959503582, 99.99m, 1)
        };
        Order order2 = new Order(products2, customer2);

        Console.WriteLine("Order 1:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.TotalPrice());
        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.TotalPrice());
        Console.WriteLine();
    }
}