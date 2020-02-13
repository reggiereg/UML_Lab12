using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    public class Student : Person
    {
        private string program;
        private int year;
        private double fee;

        public string Program
        {
            get { return program; }
            set { program = value; }
        }

        public int Year
        {
            get { return year; }
            set { year = value; }
        }

        public double Fee
        {
            get { return fee; }
            set { fee = value; }
        }

        public Student()
        {

        }

        //constructor for student.  Inherits name and address from Person
        public Student(string name, string address, string program, int year, double fee):base(name, address)
        {
            this.program = program;
            this.year = year;
            this.fee = fee;
        }

        //overrides the toString method for student to provide the Program enrolled in and the year they started
        public override string ToString()
        {
            return base.ToString() + " Program student is enrolled in: " + Program + "." + " Year: " + Year + " Fee Charged: " + Fee;
        }
    }
}
