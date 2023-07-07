using System;

public class Booking
{
    private string _date;
    private int _room;
    private string _name;
    public Booking(string date, int room, string customer)
    {
        _date = date;
        _room = room;
        _name = customer;
    }
    public string WriteInFile()
    {
        return $"{_date},{_room},{_name}";
    }
    public string GetNameInBooking()
    {
        return _name;
    }
    public string GetDate()
    {
        return _date;
    }
}