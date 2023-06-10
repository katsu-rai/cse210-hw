using System;

public class Reflecting : Activity {
    private List<string> _promptings;
    private List<string> _questions;
    public Reflecting () : base ("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflecting") {
        _promptings = new List<string>();
        _promptings.Add("Think of a time when you stood up for someone else.");
        _promptings.Add("Think of a time when you did something really difficult.");
        _promptings.Add("Think of a time when you helped someone in need.");
        _promptings.Add("Think of a time when you did something truly selfless.");

        _questions = new List<string>();
        _questions.Add("Why was this experience meaningful to you?");
        _questions.Add("Have you ever done anything like this before?");
        _questions.Add("How did you get started?");
        _questions.Add("How did you feel when it was complete?");
        _questions.Add("What made this time different than other times when you were not as successful?");
        _questions.Add("What is your favorite thing about this experience?");
        _questions.Add("What could you learn from this experience that applies to other situations?");
        _questions.Add("What did you learn about yourself through this experience?");
        _questions.Add("How can you keep this experience in mind in the future?");

    }
    public void Activity () {
        Console.Clear();
        Console.WriteLine("Get ready...");
        DisplayWaitingAnimation(4);
        Console.WriteLine();

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        DisplayRandomPrompt();
        Console.WriteLine();
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();

        Console.WriteLine();

        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("You may begin in: ");

        for (int i = 5; i > 0; i--) {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

            Console.Clear();

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(GetDuration());
        while (DateTime.Now < endTime) {
            DisplayRandomQuestion();
            Console.WriteLine();
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            // DisplayWaitingAnimation(15);
            }
    }
    public void DisplayRandomPrompt () {
        Random rnd = new Random();
        Console.Write("---");
        Console.Write(_promptings[rnd.Next(4)]);
        Console.Write("---");
    }
    public void DisplayRandomQuestion () {
        Random rnd = new Random();
        Console.Write("> ");
        Console.Write(_questions[rnd.Next(_questions.Count())]);
        Console.Write(" ");
    }
}