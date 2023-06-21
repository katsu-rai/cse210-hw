using System;

public abstract class Goal {
    protected string _goal;
    protected string _description;
    protected int _points;
    protected bool _achieved;
    public Goal (string goal, string description, int points, bool achieved = false) {
        _goal = goal;
        _description = description;
        _points = points;
        _achieved = achieved;
    }
    public abstract int RecordEvent();
    public void IsComplete(){_achieved = true;}
    public virtual void DisplayGoal() {

        string checkBox = "[ ]";
        if (_achieved) {
            checkBox ="[X]";
        }

        Console.WriteLine($"{checkBox} {_goal} ({_description})");
    }
    public abstract string WirteInFile(); 
}