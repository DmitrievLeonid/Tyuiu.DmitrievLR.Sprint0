using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DmitrievLR.Sprint0.Task4.V0.Lib
{
    public class DataService
    {
        //Сложение
        public static int Addition(int a, int b)
        {
            return a + b;
        }
        

        //Вычитание
        public static int Substraction(int a, int b)
        {
            return a - b;
        }

        //Умножение
        public static int Multiplication(int a, int b)
        {
            return a * b;
        }

        //Деление
        public static int Division(int a, int b)
        {
            return a / b;
        }
    }
}
