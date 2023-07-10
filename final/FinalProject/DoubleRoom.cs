using System;

public class DoubleRoom : Room
{
    public DoubleRoom(int roomNumber) : base(2, 75, "Twin", roomNumber) { }
    public override void DisplayDescription()
    {
        Console.WriteLine($"Double Room {_roomNumber}: Capacity {_capacity}, Bedsize {_bedsize}, Price ${_pricePerNight}");
    }
}