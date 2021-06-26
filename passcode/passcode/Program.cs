using System;

namespace passcode
{
    class Program
    {
        static void Main(string[] args)
        {
            var code = "";
            while (code != "secret")
            {

           
                Console.WriteLine("What is the passcode?");
                code = Console.ReadLine();

                if (code == "secret")
                {
                Console.WriteLine("Authenticted");

                }
                else if (code != "secret")
                {
                Console.WriteLine("Not Authenticted");
                }
             
                
            }

        }
    }
}
