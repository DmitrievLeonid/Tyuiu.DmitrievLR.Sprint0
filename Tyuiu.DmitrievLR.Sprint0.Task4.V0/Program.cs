using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint0.Task4.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task4.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //Вызов сложения
            Console.WriteLine(DataService.Addition(1, 9) + " Сложение");
            
            //Вызов вычитания
            Console.WriteLine(DataService.Substraction(15, 5) + " Вычитание");

            //Вызов умножения
            Console.WriteLine(DataService.Multiplication(10, 10) + " Умножение");

            //Вызов деления
            Console.WriteLine(DataService.Division(5, 5) + " Деление");


            Console.ReadKey();
        }
    }
}
