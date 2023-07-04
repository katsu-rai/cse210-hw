using System;

public class Customer 
{
    protected string _name;
    private string _phoneNumber;
    
    public Customer (string name, string phoneNumber) 
    {
        _name = name;
        _phoneNumber = phoneNumber;
    }
}