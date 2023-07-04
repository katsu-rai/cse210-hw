using System;

public class Suite : Room 
{
    public Suite (int roomNumber) : base(6, 220, "King", roomNumber) {}
    public override void DisplayDescription()
    {
        throw new NotImplementedException();
    }
}