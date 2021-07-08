using System;
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
                    try
                    {
                        var newStudent = new Student();
                        newStudent.Name = Util.Console.Ask("Student name:");
                        
                        Console.WriteLine("Student grade:");
                        newStudent.Grade = Util.Console.AskInt("Student grade:");

                        Console.WriteLine("Student Birthday:");
                        newStudent.Birthday = Util.Console.Ask("Student Birthday:");
                        Console.WriteLine("Student address:");
                        newStudent.Address = Util.Console.Ask("Student address:");
                        Console.WriteLine("Student phone number:");
                        newStudent.Phone = Util.Console.AskInt("Student name:");
                        students.Add(newStudent);
                        Student.Count++;
                        Console.WriteLine("Student count: {0}", Student.Count);
                        Console.WriteLine("Add another?: y/n");
                        if (Console.ReadLine() != "y")
                        {
                            adding = false;
                        }
                    }
                    catch (FormatException msg)
                    {
                        Console.WriteLine(msg.Message);
                    }

                    catch (Exception)
                    {

                        Console.WriteLine("Error adding student, please try again");
                    }

                    
                }
                foreach (var student in students)
                {
                    Console.WriteLine("Name: {0}, Grade: {1}", student.Name, student.Grade);
                }
            }
        }
        class Member
        {
            public string Name;
            public string Address;
            protected int phone;
            public int Phone
            {
                set { phone = value; }
            }
        }
        class Student : Member
        {
            static public int Count = 0;
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
        }
        class Teacher : Member
        {
            public string Subject;
        }
    }
}
