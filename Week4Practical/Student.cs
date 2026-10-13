using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Week4Practical
{
    internal class Student
    {
        //private properties
        private int _id;
        private string _name;
        private int _age;

        //public properties

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        //constructor
        public Student(int id, string name, int age)
        {
            _id = id;
            _name = name;
            _age = age;
        }
        // student1



        //methods
        public static void Display(int id, string name, int age)
        {
            Console.WriteLine("Student Details");
            Console.WriteLine($"Id: {id}");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Age: {age}");
        }







    }
}
