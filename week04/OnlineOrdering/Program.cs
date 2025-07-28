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



    }
}