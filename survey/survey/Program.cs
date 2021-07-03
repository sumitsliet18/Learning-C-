using System;

namespace survey
{
    class Data
    {
        public string Name;
        public int Age;
        public string Month;

        public void DIsplay()
        {
            Console.WriteLine("Your name is: {0}", Name);
            Console.WriteLine("Your age is: {0}", Age);
            Console.WriteLine("Your month is: {0}", Month);

            if (Month == "march")
            {
                Console.WriteLine("you are an Aries.");
            }
            else if (Month == "april")
            {
                Console.WriteLine("you are Taurus.");
            }
            else if (Month == "may")
            {
                Console.WriteLine("you are a Gemini");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var data = new Data();
            Console.WriteLine("What is your name?");
            data.Name = TryAnswer();

            Console.WriteLine("What is your age?");
            data.Age = int.Parse(TryAnswer());

            Console.WriteLine("What month were you born?");
            data.Month = TryAnswer();

            data.DIsplay();

            

            

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
