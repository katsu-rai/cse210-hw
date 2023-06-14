using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = null;
        Breathing breathing = new Breathing();
        Reflecting reflecting = new Reflecting();
        Listing listing = new Listing();

        Console.Write("What is your name?: ");
        string name = Console.ReadLine();
        Console.WriteLine();
        Console.Write($"Hello, {name}. How would you rate your mindfulness level? (1-5): ");
        Console.ReadLine();

        while (choice != "4") {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from a menu: ");
            choice = Console.ReadLine();

            switch (choice) {
                case "1":
                    breathing.DisplayStartMessage();
                    Console.WriteLine();
                    breathing.Activity();
                    breathing.DisplayEndMessage();
                    break;
                case "2":
                    reflecting.DisplayStartMessage();
                    Console.WriteLine();
                    reflecting.AskDuration();
                    reflecting.Activity();
                    reflecting.DisplayEndMessage();
                    break;
                case "3":
                    listing.DisplayStartMessage();
                    Console.WriteLine();
                    listing.AskDuration();
                    listing.Activity();
                    listing.DisplayEndMessage();
                    break;
                case "4":
                    break;
                default:
                    Console.WriteLine("Invalid response");
                    break;
            }
        }
    }
}