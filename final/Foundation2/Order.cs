public class Order
{
    private Customer _customer;
    private List<Product> _products;
    
    public Order(Customer cust)
    {
        _customer = cust;
    }

    public void AddProducts(List<Product> prods)
    {
        _products = prods;
    }
    public void GetCost()
    {
        double total = 0.00;

    foreach (Product prod in _products)
        {
          total += prod.GetCost();  
        }
        if (_customer.IsInUSA() == true)
        {
            total += 5;
        } else
        {
            total += 35;
        }
        Console.WriteLine($"Total Cost: ${total}");
    }

    public void DisplayShippingLabel()
    {
        Console.WriteLine($"Name: {_customer.GetName()}");
        Console.WriteLine($"Address: {_customer.GetAddress()}");
    }

    public void DisplayPackingLabel()
    {
        Console.WriteLine("Products:");
        foreach (Product prod in _products)
        {
            Console.WriteLine($"Product Name: {prod.GetName()}");
            Console.WriteLine($"ID: {prod.GetID()}");
            Console.WriteLine();
        }
    }
}