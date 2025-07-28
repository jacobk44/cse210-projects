using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Address and Customer
        Address address1 = new Address("123 Main ST", "Salt Lake City", "UT", "USA");
        Customer customer1 = new Customer("Allen Yates", address1);

        // Create Order and Add Product
        Order order1 = new Order(customer1);
        order1.AddProduct(new Product("Laptop", "009", 99.99m, 4));
        order1.AddProduct(new Product("Computer", "02", 996.99m, 7));

        // Display result
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine($"\nTotalPrice: {order1.GetTotalCost():0.00}");


        Console.WriteLine("................................................");
        Console.WriteLine();


        // Create Address and Customer
        Address address2 = new Address("Odikoman", "Nungua", "GreaterAccra", "GHANA");
        Customer customer2 = new Customer("James Matt", address2);

        // Create Order and Add Product
        Order order2 = new Order(customer2);
        order2.AddProduct(new Product("iphones", "009", 78.99m, 4));
        order2.AddProduct(new Product("TLC tv", "102", 700.99m, 10));

        // Display result
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine();
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine($"\nTotalPrice: {order2.GetTotalCost():0.00}");

        


    }
}