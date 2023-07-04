using System;

public class Hotel 
{
    private string _nameOfHotel;
    private List<Room> _rooms;
    private List<Booking> _bookings;
    public Hotel (string nameOfHotel)
    {
        _nameOfHotel = nameOfHotel;
        _rooms = new List<Room>();
        _bookings = new List<Booking>();
    }
}