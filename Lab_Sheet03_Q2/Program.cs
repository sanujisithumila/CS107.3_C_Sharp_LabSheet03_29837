using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_Sheet03_Q2
{
    public class Employee
    {
     
        private int employeeID;
        private string fullName;
        private double salary;

        public int EmployeeID
        {
            get { return employeeID; }
        }

        public string FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }

        public double Salary
        {
            get { return salary; }
        }

        // Constructor
        public Employee()
        {
            employeeID = 0;
            fullName = "Unknown";
            salary = 0.0;
        }

        // Parameterized constructor
        public Employee(int employeeID, string fullName, double salary)
        {
            this.employeeID = employeeID;
            this.fullName = fullName;
            this.salary = salary;
        }

        // Method to display employee info
        public void DisplayEmployeeInfo()
        {
            Console.WriteLine($"Employee ID: {employeeID}");
            Console.WriteLine($"Full Name: {fullName}");
            Console.WriteLine($"Salary: {salary:C}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of the Employee class
            Employee employee = new Employee(101, "John Doe", 50000);

            // Display the employee ID
            Console.WriteLine($"Employee ID: {employee.EmployeeID}");

            // Update the full name of the employee
            employee.FullName = "Jane Smith";

            // Attempt to modify the salary directly from external code
            // This will not compile because Salary does not have a setter
            // employee.Salary = 60000;

            // Display the employee info
            employee.DisplayEmployeeInfo();
            Console.ReadLine();
        }
    }
}
