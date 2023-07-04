using System;

public abstract class Room 
{
    private int _capacity;
    private int _pricePerNight;
    private string _bedsize;
    private int _roomNumber;
    private bool _isAvailable;
    
    public Room (int capacity, int price, string bedsize, int roomNumber, bool isAvailable = true) 
    {
        _capacity = capacity;
        _pricePerNight = price;
        _bedsize = bedsize;
        _roomNumber = roomNumber;
        _isAvailable = isAvailable;
    }
    public void IsBooked() 
    {
        _isAvailable = false;
    }
    public abstract void DisplayDescription();
}