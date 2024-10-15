using System;

class Program
{
    static void Main(string[] args)
    {
        // Addresses
        Address address1 = new Address(123, "Main St.", "Cambridge", "MA", "USA");
        Address address2 = new Address(456, "Queen St.", "Toronto", "", "Canada");

        // Customers
        Customer customer1 = new Customer("John Doe", address1);
        Customer customer2 = new Customer("Jane Smith", address2);

        // Products
        Product product1 = new Product(101, "Laptop", 1000.00);
        Product product2 = new Product(102, "Mouse", 25.00);
        Product product3 = new Product(103, "Keyboard", 45.00);
        Product product4 = new Product(104, "Monitor", 150.00);
        Product product5 = new Product(105, "Webcam", 80.00);

        //Orders
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);

        Order order2 = new Order(customer2);
        order2.AddProduct(product3);
        order2.AddProduct(product4);
        order2.AddProduct(product5);

        // Call methods for the first order
        Console.WriteLine("Order 1:");
        order1.PackingLabel();
        order1.ShippingLabel();
        order1.TotalPrice();

        // Call methods for the second order
        Console.WriteLine("Order 2:");
        order2.PackingLabel();
        order2.ShippingLabel();
        order2.TotalPrice();

    }
}