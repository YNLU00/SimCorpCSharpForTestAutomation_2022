using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Day3
{
    public class Employee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public double Salary { get; }
        public int PinCode { get; }

        public Employee(string firstName, string lastName, double salary, int pinCode)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
            PinCode = pinCode;
        }
        public string GetFullName()
        {
            return FirstName + " " + LastName;

        }
    }
    public struct SalarySlip 
    {
        public double Salary { get; set; }
        public DateTime ReportingDate { get; set; }
        public SalarySlip(double salary) {
            Salary = salary;
            ReportingDate = DateTime.Today;
        }

        public override string ToString() => $"Salary: {Salary}\nReport Date: {ReportingDate}";
    }


}
