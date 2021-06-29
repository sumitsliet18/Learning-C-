using System;

namespace survey
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = TryAnswer();

            Console.WriteLine("What is your age?");
            var age = TryAnswer();

            Console.WriteLine("What month were you born?");
            var month = TryAnswer();

            Console.WriteLine("Your name is: {0}", name);
            Console.WriteLine("Your age is: {0}", age);
            Console.WriteLine("Your month is: {0}", month);

            if (month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (month == "april")
            {
                Console.WriteLine("you are Taurus.");
            }
            else if (month == "may")
            {
                Console.WriteLine("you are a Gemini");
            }

        }
        
        static string TryAnswer()
        {
            var answer = Console.ReadLine();
            if (answer == "")
            {
                Console.WriteLine("You did not type anything, please try again");
                return Console.ReadLine();
            }
            return answer;
        }
    }
}
