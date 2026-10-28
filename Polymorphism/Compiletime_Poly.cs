using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism
{
    // 2 types of polymorphism 

    // 1st compile-time/ Method Overloading.
    // 2nd Run-time/ Method Overriding.


    //This is Compile-time/ Overloading
    class Cal
    {
        private int num1;
        private int num2;
        private int num3;

        public int Num1
        {
            get { return num1; }
            set { num1 = value; }
        }

        public int Num2
        {
            get { return num2; }
            set { num2 = value; }
        }

        public int Num3
        {
            get { return num3; }
            set { num3 = value; }
        }
        //****************************************************************
        public string Add(string a, string b)
        {
            return a + b;
        }
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        public int Add(int a, int b, int c, int d, int e)
        {
            return (a + b + c + d + e);
        }

        public int Add(double a, double b)
        {
            return (int)a + (int)b; // Type Casting
        }

        public int Add(int a, byte b)
        {
            return a + b;
        }

    }
    //****************************************************************

    //Another Code of Polymorphism using "Void"
    class Printer
    {
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Print(int num)
        {
            Console.WriteLine(num);
        }

        public void Print(double value) 
        {
            Console.WriteLine(value);
        }
    }
    //****************************************************************

    class School
    {
        public void Student(string name)
        {
            Console.WriteLine("Student Name is " + name);
        }

        public void Student(int id)
        {
            Console.WriteLine("Student Id is " + id);
        }

        public void Student(double height)
        {
            Console.WriteLine("Student height is "+ height);
        }
    }
    //****************************************************************


    
}
