using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int answer = randomGenerator.Next(1, 101);
        int user_answer = -1;

        while (user_answer != answer)
        {
            Console.Write("What is your guess? ");
            string user_answer_string = Console.ReadLine();
            user_answer = int.Parse(user_answer_string);

            if (user_answer > answer)
            {
                Console.WriteLine("Lower");
            }
            else if (user_answer < answer)
            {
                Console.WriteLine("Higher");
            }
            else if (user_answer == answer)
            {
                Console.WriteLine("You gueesed it!");
            }
        }
    }
}