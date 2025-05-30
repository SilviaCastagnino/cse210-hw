using System;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
        _products = new List<Product>();
    }

    public double CalculateTotalCost()
    {
        double result = 0;
        foreach (Product product in _products)
        {
            result += product.GetTotalCost();
        }
        if (_customer.IsInTheUsa())
        {
            result += 5;
        }
        else
        {
            result += 35;
        }
        return result;
    }

    public string GetPackingLabel()
    {
        return "145 Wall Street, New York, New York, USA";
    }

    public string GetShippingLabel()
    {
        return _customer.GetAddress();
    }

    public void AddProduct(Product product)
    {
        _products.Add(product);
    }

}