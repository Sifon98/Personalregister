using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personalregister
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaring the needed variables
            var personalRegister = new List<Employee>();
            bool openProgram = true;
            int employeeLength = 0;
            string employeeName;
            double employeeWage;
            int number;

            while (openProgram)
            {
                // Menu for the program
                Console.WriteLine("1. Register worker");
                Console.WriteLine("2. Print register");
                Console.WriteLine("3. Close program");
                string input = Console.ReadLine();

                // See if the user actually input a number
                int.TryParse(input, out number);

                switch (number)
                {
                    case 1:
                        Console.WriteLine("");
                        Console.Write("Write the name of the employee: "); employeeName = Console.ReadLine();
                        Console.Write("Write the wage of the employee: "); employeeWage = double.Parse(Console.ReadLine());

                        // Add a new employee to a list
                        var newEmployee = new Employee(employeeName, employeeWage);
                        personalRegister.Add(newEmployee);

                        // used to count how many employees there are
                        employeeLength++;
                        break;
                    case 2:
                        // In case you the user forgot to add a employee
                        if (employeeLength == 0)
                            Console.WriteLine("");
                            Console.WriteLine("You should to try to add an employee first.");

                        for (int i = 0; i < employeeLength; i++)
                        {
                            Console.WriteLine("");
                            Console.WriteLine($"Employee number {i + 1}");
                            Console.WriteLine($"Name: {personalRegister[i].fullName}");
                            Console.WriteLine($"Wage: {personalRegister[i].wage}");
                        }
                        break;
                    case 3:
                        openProgram = false;
                        break;
                    default:
                        Console.WriteLine("");
                        Console.WriteLine("That is not a valid input.");
                        break;
                }

                // Some nice styling for the program
                Console.WriteLine("");
                Console.WriteLine("==========================");
                Console.WriteLine("");
            }
        }
    }

    // A new class for the array
    class Employee
    {
        public String fullName;
        public double wage;

        public Employee(String fullName, double wage)
        {
            this.fullName = fullName;
            this.wage = wage;
        }
    }
}
