public class Product
{
    private string _productName;
    private int _productId;
    private double _productPrice;
    private int _productQuantity;


    public Product(int id, string name, double price)
    {
        _productId = id;
        _productName = name;
        _productPrice = price;       

    }
    public string GetProductName()
    {
        return _productName;
    }

    public int GetProductId()
    {
        return _productId;
    }
    public double GetPrice()
    {
        return _productPrice;
    }

    public int GetQuantity()
    {
        return _productQuantity;
    }  
    public double TotalPrice(double price, int qty)
    {
       return price * qty;
    }
}