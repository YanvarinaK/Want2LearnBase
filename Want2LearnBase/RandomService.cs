using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
   public static class RandomService
    {
        public static int GetRandomValue(int minValue, int maxValue, Random rnd)
        {
            int RandomValue = rnd.Next(minValue, maxValue);
            return RandomValue;
        }

        public static double GetRandomValue(double minValue, double maxValue, Random rnd)
        {
            double RandomValue = rnd.NextDouble() * (maxValue - minValue) + minValue;
            return RandomValue;
        }

        public static char GetRandomValue(char minValue, char maxValue, Random rnd)
        {
            int max = (int)maxValue;
            int min = (int)minValue;
            int randomValue = rnd.Next(min, max);
            char RandomValue = (char)randomValue;
            return RandomValue;
        }

        public static int[] GetRandomArray(int minValue, int maxValue, int arrayLength, Random rnd)
        {
            int[] Array = new int[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Array[i] = rnd.Next(minValue, maxValue);
            }
            return Array;
        }

        public static int[,] GetRandomMatrix(int minValue, int maxValue, int rows, int columns, Random rnd)
        {
            int[,] Matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Matrix[i, j] = rnd.Next(minValue, maxValue);
                }
            }
            return Matrix;
        }

        public static string GetRandomString(int stringLength, Random rnd)
        {
            char[] randomArray = new char[stringLength];
            for (int i = 0; i < stringLength; i++)
            {
                randomArray[i] = GetRandomValue(char.MinValue, char.MaxValue, rnd);
            }
            string RandomString = new string(randomArray);
            return RandomString;
        }

        public static string GetRandomWord(int stringLength, Random rnd)
        {
            char[] randomArray = new char[stringLength];
            char[] AllLetters = GetArrayOfEngRusLetters();
            for (int i = 0; i < stringLength; i++)
            {
                randomArray[i] = AllLetters[rnd.Next(0, AllLetters.Length - 1)];
            }
            string RandomString = new string(randomArray);
            return RandomString;
        }
    }
}
