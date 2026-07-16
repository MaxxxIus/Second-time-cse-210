using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Jakes order:");
        Address address = new Address("135th c e", "Mixus", "Californa", "USA");
        Customer customer = new Customer("Jake Paul", address);
        Order order = new Order(customer);
        List<Product> products = new List<Product>();
        Product prod1 = new Product("Apple Juice", "Au92345", 3.14, 3);
        Product prod2 = new Product("Jeans", "JC2468", 5.00, 2);
        products.Add(prod1);
        products.Add(prod2);
        order.AddProducts(products);
        order.DisplayShippingLabel();
        order.DisplayPackingLabel();
        order.GetCost();
        Console.WriteLine();

        Console.WriteLine("Williams Order:");
        address = new Address("40008 32nd st ct e", "Brigum", "Braxton", "England");
        customer = new Customer("William Afton", address);
        order = new Order(customer);
        products = new List<Product>();
        prod1 = new Product("Kitchen Knife", "KK22091", 7.80, 10);
        products.Add(prod1);
        prod2 = new Product("Bleach", "B802983", 2.50, 6);
        products.Add(prod2);
        Product prod3 = new Product("Peperoni Slices", "PS24801", 4.33, 3);
        products.Add(prod3);
        order.AddProducts(products);
        order.DisplayShippingLabel();
        order.DisplayPackingLabel();
        order.GetCost();
    }
}