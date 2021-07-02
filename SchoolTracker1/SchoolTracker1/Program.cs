﻿using System;
using System.Collections.Generic;

namespace SchoolTracker1
{
    class Program
    {
        static void Main(string[] args)
        {
            Import();
            static void Import()
            {
                var importedStudent = new Student("Sumit", 80, "birthday", "address", 122345);
                Console.WriteLine(importedStudent.Name);
            }
            {
                var students = new List<Student>();

                var adding = true;
                while (adding)
                {
                    var newStudent = new Student();

                    newStudent.Name = Util.Console.Ask("Student name:");

                    Console.WriteLine("Student grade:");
                    newStudent.Grade = int.Parse(Util.Console.Ask("Student grade:"));

                    Console.WriteLine("Student Birthday:");
                    newStudent.Birthday = Util.Console.Ask("Student Birthday:");

                    Console.WriteLine("Student address:");
                    newStudent.Address = Util.Console.Ask("Student address:");

                    Console.WriteLine("Student phone number:");
                    newStudent.Phone = int.Parse(Util.Console.Ask("Student name:"));

                    students.Add(newStudent);
                    Student.Count++;
                    Console.WriteLine("Student count: {0}", Student.Count);

                    Console.WriteLine("Add another?: y/n");
                    if (Console.ReadLine() != "y")
                    {
                        adding = false;
                    }
                }
                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                }

            }
        }
        class Student
        {
            static public int Count;

            public string Name;
            public int Grade;
            public string Birthday;
            public string Address;
            private int phone;

            public Student()
            {

            }

            public Student(string name, int grade, string birthday, string address, int phone)
            {
                Name = name;
                Grade = grade;
                Birthday = birthday;
                Address = address;
                Phone = phone;
            }

            public int Phone
            {
                set { phone = value; }
            }

            public void SetPhone(int number)
            {
                phone = number;
            }
        }

    }
}
