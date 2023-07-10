using System;

public abstract class Room
{
    protected int _capacity;
    protected int _pricePerNight;
    protected string _bedsize;
    protected int _roomNumber;
    private List<string> _bookedDate;

    public Room(int capacity, int price, string bedsize, int roomNumber)
    {
        _capacity = capacity;
        _pricePerNight = price;
        _bedsize = bedsize;
        _roomNumber = roomNumber;
        _bookedDate = new List<string>();
    }
    public abstract void DisplayDescription();
    public List<string> GetBookedDate()
    {
        return _bookedDate;
    }
    public bool IsAvailable(string date)
    {
        foreach (string bookedDate in _bookedDate)
        {
            if (date == bookedDate)
            {
                return false;
            }
        }
        return true;
    }
}