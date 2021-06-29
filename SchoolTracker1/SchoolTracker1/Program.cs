using System;

namespace SchoolTracker1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many students in your class?");
            var StudentCount = int.Parse(Console.ReadLine());
            var studentNames = new string[StudentCount];
            var studentGrades = new int[StudentCount];

            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine("Student name:");
                studentNames[i] = Console.ReadLine();

                Console.WriteLine("Student grade:");
                studentGrades[i] = int.Parse(Console.ReadLine());
            }


            for (int i = 0; i < StudentCount; i++)
            {
                Console.WriteLine("Name: {0}, Grade: {1}", studentNames[i], studentGrades[i]);
            }

        }
    }
}
