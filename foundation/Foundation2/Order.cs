using System.Globalization;

public class Order
{
    private List <Product> _products = new List <Product> ();
    private Customer _customer;

    public Order(Customer customer)
    {
       _customer = customer;
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

    //Total the product prices and add shipping depending if in USA or not
    

    public void PackingLabel()
    {
        Console.WriteLine($"Packing Label for {_customer.GetName()}:");
        foreach (Product product in _products)
        { string name = product.GetProductName(); 
          int id = product.GetProductId();
          Console.WriteLine($"Product name: {name} - id:{id}");
        }
        Console.WriteLine("");
    }
    
    public void ShippingLabel()
    {
       string customer =  _customer.GetName();
       string address =  _customer.GetAddress().GetAddressString();
       Console.WriteLine($"Shipping Label:\n{customer}\n{address}");
       Console.WriteLine();
    }

    public void TotalPrice()
    {
        double totalPrice = 0;

        foreach (Product product in _products)
        {
            totalPrice += product.GetPrice();
            
        }

        if(_customer.InUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice +=35;
        }
        Console.WriteLine($"Total Price (including shipping): ${totalPrice}");
        Console.WriteLine();
    }
}