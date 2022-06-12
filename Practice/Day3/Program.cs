using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee empl1 = new Employee("John", "Doe", 0, 1111);
            string FullName = empl1.GetFullName();
            SalarySlip salarySlip = new SalarySlip();

            Console.WriteLine(FullName);
            Console.WriteLine(empl1.Salary);
            Console.WriteLine(empl1.PinCode);
            Console.WriteLine(salarySlip);

            DateTime newDateTime = DateTime.Today.AddDays(-1);
            double newSalary = 11;
            SalarySlipUpdate(salarySlip, newSalary, newDateTime);
            Console.WriteLine("Update Salary");
            Console.WriteLine(salarySlip);

        }
        private static void SalarySlipUpdate(SalarySlip salary, double newSalary, DateTime newDateTime)
        {
            salary.Salary = newSalary;
            salary.ReportingDate = newDateTime;
        }

    }
}
