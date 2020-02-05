using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Person
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

        public Person(string name, string address)
        {
            this.name = name;
            this.address = address;
        }
    }
}
