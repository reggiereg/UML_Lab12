using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    //Person class that can be a student or staff member
    public class Person
    {
        private string name;
        private string address;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return name; }
            set { name = value; }
        }

        public Person()
        {

        }

        //Constructor for Person class.  Name and address are captured here for students and staff members
        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }

        //overrides ToString method for Person object to provide the students name and address
        public override string ToString()
        {
            return base.ToString() + " Persons name is: "+Name+". "+ " Persons address is: "+address;
        }
    }
}
