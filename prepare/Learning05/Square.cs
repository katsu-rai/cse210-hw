using System;

public class Square : Shape {
    private double _side;

    public Square (string color, double side) {
        SetColor(color);
        _side = side;
    }

    public override double GetArea()
    {
        return Math.Round(_side * _side, 2); 
    }
}