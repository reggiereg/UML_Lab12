using System;
using System.Collections.Generic;
using System.Text;

namespace Lab12_ClassUML
{
    class Staff : Person
    {
        private string school;
        private double pay;

        public string School
        {
            get { return school; }
            set { school = value; }
        }

        public double Pay
        {
            get { return pay; }
            set { pay = value; }
        }

        public Staff()
        {

        }

        //constructor for staff member.  Inherits name and address from Person
        public Staff(string name, string address, string school, double pay):base(name, address)
        {
            this.school = school;
            this.pay = pay;
        }

        //overrides the ToString method for staff member to provide the school and pay of the staff member
        public override string ToString()
        {
            return base.ToString() + "Staff Members School: " + School + "Staff Members Pay: " + Pay;
        }
    }
}
