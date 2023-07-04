using System;

public class Double : Room 
{
    public Double (int roomNumber) : base(2, 75, "Twin", roomNumber) {}
    public override void DisplayDescription()
    {
        throw new NotImplementedException();
    }
}