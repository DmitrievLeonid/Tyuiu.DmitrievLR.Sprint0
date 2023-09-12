using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.DmitrievLR.Sprint0.Task6.V0.Lib;

namespace Tyuiu.DmitrievLR.Sprint0.Task6.V0
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numsArray = new int[] { 1, 2, 3, 4, 5 };

            // AdditionArray
            Console.WriteLine("Сумма элементов массива: " + DataService.AdditionArray(numsArray));

            //Substraction
            Console.WriteLine("Разность элементов массивов: " + DataService.SubstractionArray(numsArray));

            //Multiplication
            Console.WriteLine("Произведение элменетов массивов: " + DataService.MultiplicationArray(numsArray));



            Console.ReadKey();
        }
    }
}
