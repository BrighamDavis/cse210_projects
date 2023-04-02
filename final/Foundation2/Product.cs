using System;
using System.Collections;

public class Product
{
    private string _productName;
    private int _productId;
    private int _price;
    private int _quantity;

    public int GetTotalPrice()
    {
        return _price * _quantity; //+ GetShipping();
    }

    public List<Product> products {get; set; } = new List<Product>();

    public void SetProduct(int productId, string productName, int price, int quantity)
    {
        _productId = productId;
        _productName = productName;
        _price = price;
        _quantity = quantity;
    }
    public void DisplayPackingLabel()
    {
        foreach (Product product in products)
            {
                Console.WriteLine("");
                Console.WriteLine($"{_productId} {" "} {_productName} {" x "} {_quantity})");
            }
    }


}