using System;

public class Customer
{
    protected string _name;
    private List<Booking> _myBookings;

    public Customer(string name)
    {
        _name = name;
        _myBookings = new List<Booking>();
    }
    public void AddBookingToCustomer(Booking newBooking)
    {
        _myBookings.Add(newBooking);
    }
}