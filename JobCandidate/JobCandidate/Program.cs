﻿using System;

namespace JobCandidate
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many years of experience do you have?");

            var years = int.Parse(Console.ReadLine());

            switch(years)
            {
                case 0:
                    Console.WriteLine("Inexperienced");
                    break;

                case 1:
                    Console.WriteLine("junior");
                    break;
                case 2:
                    Console.WriteLine("intermediate");
                    break;
                case 3:
                    Console.WriteLine("advanced");
                    break;
                default:
                    Console.WriteLine("senior");
                    break;

            }
     

        }
    }
}
