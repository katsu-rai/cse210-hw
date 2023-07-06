using System;

public class Customer
{
    protected string _name;
    private string _phoneNumber;
    private List<Booking> _myBookings;

    public Customer(string name, string phoneNumber)
    {
        _name = name;
        _phoneNumber = phoneNumber;
        _myBookings = new List<Booking>();
    }
    public string GetCustomerName()
    {
        return _name;
    }
}