using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyuiu.DmitrievLR.Sprint0.Task7.V0.Lib
{
    public class DataService
    {
        public static int[] AdditionArrays(int[] numOne, int[] numTwo)
        {
            int[] ResultArray = new int[5];// так объявляетска кол-во элементов массива 

            for (var i = 0; i < ResultArray.Length; i++)
            {
                ResultArray[i] = numOne[i] + numTwo[i]; 
            }

            return ResultArray;
        }
    }
}
