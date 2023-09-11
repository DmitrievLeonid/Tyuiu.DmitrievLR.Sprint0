using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint0.Task5.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task5.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            // Сложение
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));

            //Вычитание
            Console.WriteLine("A - B = " + DataService.Substraction(15, 5));

            //Умножение
            Console.WriteLine("A * B = " + DataService.Multiplication(10, 10));

            //Деление с условием if
            Console.WriteLine("A / b = " + DataService.Division(6,3));

            Console.ReadKey();
        }
    }
}
