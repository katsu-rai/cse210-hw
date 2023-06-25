using System;

public class Eternal : Goal {
    public Eternal (string goal, string description, int points) : base(goal, description, points){}
    public override int RecordEvent() {
        int returnPoints = _points;
        return returnPoints;
    }
    public override string WriteInFile() {
            return $"EternalGoal:{_goal},{_description},{_points}";
    }
}