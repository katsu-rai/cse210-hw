using System;

public class Booking
{
    private string _date;
    private int _room;
    private Customer _name;
    public Booking(string date, int room, Customer customer)
    {
        _date = date;
        _room = room;
        _name = customer;
    }
    public void WriteInFile()
    {
        Console.WriteLine($"{_date}, {_room}, {_name.GetCustomerName()}");
    }
    public string GetNameInBooking()
    {
        return _name.GetCustomerName();
    }
    public string GetDate()
    {
        return _date;
    }
}