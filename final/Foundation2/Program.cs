using System;

class Program
{
    static void Main(string[] args)
    {
        // Create address
        Address address1 = new Address("123 Main St", "City1", "State1", "USA");
        Address address2 = new Address("456 Elm St", "City2", "State2", "Canada");

        // Create customers
        Customer customer1 = new Customer("Customer 1: Tom Cruise", address1);
        Customer customer2 = new Customer("Customer 2: Lisa Perry", address2);

        // Create products
        Product product1 = new Product("Product 1: Cup Holder", 1, 10.5m, 2);
        Product product2 = new Product("Product 2: Desk", 2, 15.75m, 3);
        Product product3 = new Product("Product 3: Beddings", 3, 5.0m, 1);

        // Create orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product2);
        order2.AddProduct(product3);

        // Display order details
        Console.WriteLine("Order 1:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.CalculateTotalCost());

        Console.WriteLine();

        Console.WriteLine("Order 2:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.CalculateTotalCost());
    }
}