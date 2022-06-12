using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice3
{
    class Program
    {
        static void Main(string[] args)
        {
            //practice 3
            //Console.WriteLine("Please insert the first integer:");
            //int num1 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please insert the second integer:");
            //int num2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("Please insert the third integer:");
            //int num3 = int.Parse(Console.ReadLine());

            //int sum = num1 + num2 + num3;
            //int product = num1 * num2 * num3;
            //float average = sum / 3f;
            //Console.WriteLine($"Sum:{sum}\n product:{product} \n average:{average}\n");
            //bool CompareFirstSecond = num1 > num2;
            //Console.WriteLine($"The first number is larger than the second:{CompareFirstSecond}");


            int? variable1= null;
            int? variable2 = 1;
            int? variable3 = 2;
            Console.WriteLine($"var1:{variable1??0},var2:{variable2 ?? 0},var3:{variable3 ?? 0}");


            Console.ReadKey();

        }
    }
}
