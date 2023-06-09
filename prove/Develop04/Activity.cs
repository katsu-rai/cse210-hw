using System;

public class Activity {

    private string _description;
    private int _duration;
    private string _activityName;
    public Activity (string description, string activityName) {
        _description = description;
        _duration = 0;
        _activityName = activityName;
    }
    public void DisplayStartMessage () {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_activityName} Activity.");
        Console.WriteLine();
        Console.WriteLine(_description);
    }
    public void DisplayEndMessage () {
        Console.WriteLine("Well done!!");
        DisplayWaitingAnimation(4);
        Console.WriteLine();
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} Activity.");
        DisplayWaitingAnimation(4);
    }
    public void AskDuration () {
        Console.WriteLine("How long, in seconds, would you like for your session?");
        Console.Write("=>");
        _duration = int.Parse(Console.ReadLine());
    }
    public int GetDuration () {
        return _duration ;
    }
    public void DisplayWaitingAnimation (int durationOfAnimationInSecond) {
        List<string> animationString = new List<string>();
        animationString.Add("|");
        animationString.Add("/");
        animationString.Add("-");
        animationString.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(durationOfAnimationInSecond);

        int i = 0;
        while (DateTime.Now < endTime) {
            Console.Write(animationString[i]);
            Thread.Sleep(300);
            Console.Write("\b \b");

            i++;

            if (i >= animationString.Count) {
                i = 0;
            }
        }
    }
}