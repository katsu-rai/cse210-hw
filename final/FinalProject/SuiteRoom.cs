using System;

public class SuiteRoom : Room
{
    public SuiteRoom(int roomNumber) : base(6, 270, "King", roomNumber) { }
    public override void DisplayDescription()
    {
        Console.WriteLine($"Suite Room {_roomNumber}: Capacity {_capacity}, Bedsize {_bedsize}, Price ${_pricePerNight}");
    }
}