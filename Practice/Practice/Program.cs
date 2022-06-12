using System;
using MessageLibrary;


namespace Practice
{
    enum currency{ 
        EUR,
        USD
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Messenger m = new Messenger();
            //Console.WriteLine(m.GetMessage());

            Console.WriteLine("Please input your first name and last name:");
            string name = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please input the number of full years of work experience:");
            var YearsOfWorkExperience = Console.ReadLine();
            
            Console.WriteLine($"Hello {name}! Your work experience:{YearsOfWorkExperience} year(s)");

            var CurrencyInfo = currency.EUR;
            Console.WriteLine($"Currency of your salary: {CurrencyInfo}");

            Console.ReadKey();
        }
    }
}
