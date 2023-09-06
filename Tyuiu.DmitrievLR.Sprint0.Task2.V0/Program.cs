using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint0.Task2.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task2.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            //пишется в консоль команда GetMessage из библиотеки
            Console.WriteLine(DataService.GetMessage("Леонид"));

            //ожидание
            Console.ReadKey();
        }
    }
}
