using System;

public class Single : Room
{
    public Single(int roomNumber) : base(1, 40, "Single", roomNumber) { }
    public override void DisplayDescription()
    {
        Console.WriteLine($"Single Room {_roomNumber}: Capacity {_capacity}, Bedsize {_bedsize}, Price ${_pricePerNight}");
    }
}