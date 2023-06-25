using System;

public class Simple : Goal {
    public Simple (string goal, string description, int points, bool achieved) 
    : base(goal, description, points, achieved){}
    public override int RecordEvent()
    {
        IsComplete();
        int returnPoints  = _points;
        return returnPoints;
    }
    public override string WriteInFile()
    {
            return $"SimpleGoal:{_goal},{_description},{_points},{_achieved}";
    }
}