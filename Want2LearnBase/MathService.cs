using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
   public static class MathService
    {
        private static void Sort(ref int firstNumber, ref int secondNumber)
        {
            if (firstNumber < secondNumber)
            {
                Swap(ref firstNumber, ref secondNumber);
            }
        }

        public static int FindNOD(int firstNumber, int secondNumber)
        {
            Sort(ref firstNumber, ref secondNumber);

            int result;
            int ost;
            do
            {
                if (secondNumber == 0)
                    break;
                ost = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = ost;
            }
            while (ost != 0);
            result = firstNumber;
            return result;
        }
    }
}
