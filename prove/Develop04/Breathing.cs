using System;

public class Breathing : Activity {
    public Breathing () : base("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing") {}
    public void Activity () {
        DateTime startTime = DateTime.Now;
        AskDuration();
        DateTime endTime = startTime.AddSeconds(GetDuration());
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayWaitingAnimation(4);
        Console.WriteLine("");

        while (DateTime.Now < endTime) {
            DisplayBreathIn();
            Console.WriteLine();
            DisplayBreathOut();
            Console.WriteLine();
            Console.WriteLine();
        }
    }
    public void DisplayBreathIn () {
        Console.Write("Breath in...");
        for (int i = 4; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void DisplayBreathOut () {
        Console.Write("Breath out...");
        for (int i = 6; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}