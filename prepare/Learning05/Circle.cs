using System;

public class Circle : Shape {
    private double _radius;

        public Circle (string color, double radius) {
        SetColor(color);
        _radius = radius;
    }

    public override double GetArea()
    {
        return Math.Round(_radius * _radius * Math.PI, 2);
    }
}