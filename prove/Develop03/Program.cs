using System;

class Program
{
    static void Main(string[] args)
    {
        // Create scripture object
        Console.Clear();
        Scripture scripture = new Scripture("Isaiah", "29", "10", "0", "For the Lord hath poured out upon you the spirit of deep sleep, and hath closed your eyes: the prophets and your rulers, the seers hath he covered.");
        string response = " ";

        while (response != "quit") {
            scripture.DisplayScripture();
            Console.Write("Press enter to continue, \"reset\" to redo, or \"quit\" to finish: ");
            response = Console.ReadLine();
            Console.WriteLine();

            switch (response) {
                case "quit":
                    break;

                case "":
                    if (!scripture.GetAllWordsHidden()) {
                        scripture.HideRandomWord();
                        scripture.HideRandomWord();
                        scripture.HideRandomWord();
                    }
                    else {
                        response = "quit";
                    }
                    break;

                case "reset":
                    scripture.Reset("Isaiah", "29", "10", "0", "For the Lord hath poured out upon you the spirit of deep sleep, and hath closed your eyes: the prophets and your rulers, the seers hath he covered.");
                    break;


                default:
                    Console.WriteLine("Invalid response");
                    break;
            }
        }
    }
}