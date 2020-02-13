using System;
using System.Collections.Generic;

namespace Lab12_ClassUML
{
    class Program
    {
        static void Main(string[] args)
        {
            //list of people
            List<Person> people = new List<Person>()
            {
                new Student("Reginald Richardson", "18061 Winthrop", "C#", 2020, 10000.00),
                new Student("Sable Morgan", "19024 Sussex", "Java", 2019, 9000.00),
                new Student("Morris Dickerson", "19552 Coyle", "Front End", 2020, 10000.00),
                new Staff("Gloria Davidson", "12228 Asbury Park", "Focus:HOPE", 55000.00),
                new Staff("Peter Parker", "17035 Clarita", "Grand Circus", 60000.00)
            };

            //Prints menu to either add a staff member or a student
            PrintMenu();

            //validates user input to to be either 1 or 2
            int userOption = ValidateInput(GetUserInput("Option: "), 1, 2);



        }

        //print menu method
        public static void PrintMenu()
        {
            Console.WriteLine("Would you like to:\n     1. Add a staff member\n     2. Add a student\n ");
        }

        //method to get users input
        public static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }


        //validates the users input
        public static int ValidateInput(string input, int min, int max)
        {
            int option;

            //message to be used in catch and invalid input instances
            string message = $"Invalid selection. Please enter " + min + " or " + max;
            try
            {

                //trys to parse users input as an integer
                option = int.Parse(input);

                //makes sure the value entered is within a specific range
                if(option >= min && option <= max)
                {
                    return option;
                }

                //recursion until user provides a value within the a specific range
                else
                {
                    return ValidateInput(GetUserInput(message), min, max);
                }
            }

            //recursion until user provides a value that is parsable as an integr
            catch
            {
                return ValidateInput(GetUserInput(message), min, max);
            }
        }

        public static double ValidateInput(string input)
        {
            double option;
            try
            {
                option = int.Parse(input);
                return option;
            }
            catch
            {
                return ValidateInput(GetUserInput("Invalid entry. Please enter in the salary of the staff member (i.e. 55000): "));
            }
        }

        public static int ValidateIntInput(string input)
        {
            int option;
            try
            {
                option = int.Parse(input);
                return option;
            }
            catch
            {
                return ValidateIntInput(GetUserInput("Invalid entry. Please enter in the year the student started (i.e. 1951): "));
            }
        }

        //method to add a student or staff member
        public static List<Person> AddStudentOrStaff(List<Person> people, int option)
        {
            string name;
            string address;
            //get staff member information
            if(option == 1)
            {
                name = GetUserInput("Enter in the name of the staff member: ");
                address = GetUserInput("Enter in the address of th staff member: ");
                string school = GetUserInput("Enter in the school of the staff member: ");
                double pay = ValidateInput(GetUserInput("Enter in the pay of the new staff member: "));
                Person sobject = new Staff(name, address, school, pay);
                people.Add(sobject);
                return people;
            }

            //get the staff members information
            else 
            {
                name = GetUserInput("Enter in the name of the staff member: ");
                address = GetUserInput("Enter in the address of th staff member: ");
                string program = GetUserInput("Enter in the school of the staff member: ");
                int year = ValidateIntInput(GetUserInput("Enter in the pay of the new staff member: "));
                double fee = ValidateInput(GetUserInput("Enter in the fee for the program: "));
                Person sobject = new Student(name, address, program, year, fee);
                people.Add(sobject);
                return people;
            }
        }
    }
}
