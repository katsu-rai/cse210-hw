using System;

public class Listing : Activity {
    List<string> _promptings;
    public Listing () : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing") {
        _promptings = new List<string>();
        _promptings.Add("Who are people that you appreciate?");
        _promptings.Add("What are personal strengths of yours?");
        _promptings.Add("Who are people that you have helped this week?");
        _promptings.Add("When have you felt the Holy Ghost this month?");
        _promptings.Add("Who are some of your personal heroes?");
    }

    public void Activity () {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayWaitingAnimation(4);
        Console.WriteLine();

        Console.WriteLine("List as many responces you can to the following prompt:");
        DisplayRandomPrompt();
        Console.WriteLine();

        Console.Write("You may begin in: ");
        for (int i = 5; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime) {
            Console.Write("> ");
            Console.ReadLine();
            }

    }
    public void DisplayRandomPrompt(){
        Random rnd = new Random();
        Console.Write(" --- ");
        Console.Write(_promptings[rnd.Next(4)]);
        Console.Write(" --- ");
    }
}