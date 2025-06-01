using System;

public class Product
{
    private string _productName;
    private string _productId;
    private double _productPrice;
    private int _productQuantity;

    public Product(string productName, string productId, double productPrice, int productQuantity)
    {
        _productName = productName;
        _productId = productId;
        _productPrice = productPrice;
        _productQuantity = productQuantity;
    }

    public string GetProductName()
    {
        return _productName;
    }

    public double GetTotalCost()
    {
        return _productPrice * _productQuantity;
    }
}
