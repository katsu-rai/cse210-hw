using System;

public class Single : Room 
{
    public Single (int roomNumber) : base(1, 40, "Single", roomNumber) {}
    public override void DisplayDescription()
    {
        throw new NotImplementedException();
    }
}