using System;

public class TripleRoom : Room
{
    public TripleRoom(int roomNumber) : base(3, 100, "Single", roomNumber) { }
    public override void DisplayDescription()
    {
        Console.WriteLine($"Triple Room {_roomNumber}: Capacity {_capacity}, Bedsize {_bedsize}, Price ${_pricePerNight}");
    }
}