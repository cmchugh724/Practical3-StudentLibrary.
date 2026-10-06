using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;

namespace StudentLibrary
{
    internal class Student
    {

        private int id;
        private string name;

        private int age;

        private static int studentCount = 0;

        public int ID
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public static int StudentCount
        {
            get { return studentCount; }
        }

        public Student()
        {
            name = "John Doe";
            age = 16;
            id = studentCount++;
        }

        public Student(String name, int age)
        {
            this.name = Name;
            this.age = Age;
            id = studentCount++;
        }

        public void Display()
        {
Console.WriteLine("StudentID:" + id + " Name: " + name + " Age: " + age);
        }
        public int GetOlder()
        {
           return age++;
        }


    }
}
