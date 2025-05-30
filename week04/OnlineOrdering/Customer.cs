using System;

public class Customer
{
    private string _customerName;
    private Address _customerAddress;

    public Customer(string customerName, Address customerAddress)
    {
        _customerName = customerName;
        _customerAddress = customerAddress;
    }

    public bool IsInTheUsa()
    {
        return _customerAddress.IsInTheUsa();
    }

    public string GetName()
    {
        return _customerName;
    }

    public string GetAddress()
    {
        return _customerAddress.GetFullAddress();
    }
}