using System;

public class Booking 
{
    private string _date;
    private string _room;
    private Customer _name;
    public Booking (string date, string room, Customer customer) 
    {
        _date = date;
        _room = room;
        _name = customer;
    }
}