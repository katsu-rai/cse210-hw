using System;

public class Checklist : Goal {
    private int _bonusPoints;
    private int _howManyHasToBeCompleted;
    private int _attempts;
    public Checklist (string goal, string description, int points, int bonusPoints, int howManyHasToBeCompleted, int attempts=0) : base(goal, description, points){
        _bonusPoints = bonusPoints;
        _howManyHasToBeCompleted = howManyHasToBeCompleted;
        _attempts = attempts;
        _achieved = (attempts >= howManyHasToBeCompleted) ? true : false;
    }
    public override int RecordEvent()
    {
        int returnPoints = 0;
        _attempts ++;
        if (_attempts == _howManyHasToBeCompleted) {
            returnPoints += _bonusPoints;
            IsComplete();
        }
        returnPoints += _points;
        return returnPoints;
    }
        public override void DisplayGoal() {

        string checkBox = "[ ]";
        if (_achieved) {
            checkBox ="[X]";
        }

        Console.WriteLine($"{checkBox} {_goal} ({_description}) -- Currently completed: {_attempts}/{_howManyHasToBeCompleted}");
    }
    public override string WirteInFile()
    {
        return $"ChecklistGoal:{_goal},{_description},{_points},{_bonusPoints},{_howManyHasToBeCompleted},{_attempts}";
    }
}