using System;

public class Hotel
{
    private string _nameOfHotel;
    private List<Room> _rooms;
    private List<Booking> _bookings;
    public Hotel(string nameOfHotel)
    {
        _nameOfHotel = nameOfHotel;
        _rooms = new List<Room>();
        _bookings = new List<Booking>();
    }
    public void AddRoomToHotel(Room newRoom)
    {
        _rooms.Add(newRoom);
    }
    public List<Room> GetRooms()
    {
        return _rooms;
    }
    public void AddBookingToHotel(Booking newBooking)
    {
        _bookings.Add(newBooking);
    }
    public List<Booking> GetBookings()
    {
        return _bookings;
    }
    public void DeleteBookingFromList(Booking cancelBooking)
    {
        _bookings.Remove(cancelBooking);
    }
}