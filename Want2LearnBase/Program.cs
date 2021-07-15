using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
    class Program
    {
        static void Main(string[] args)
        {
            
        }
        public static int[] RandomArray(int number, Random rnd)
        {
            int[] Array = new int[number];
            for (int i = 0; i < number; i++)
            {
                Array[i] = rnd.Next(-10, 10);
            }
                return Array;
        }
        public static void PrintArray(int[] Array)
        {
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write($"{Array[i]} ");
            }
            Console.WriteLine();
        }
        public static void BubbleSort(int[] Array)
        {
            int Temp;
            for (int i = 0; i < Array.Length; i++)
            {
                for (int j = i + 1; j < Array.Length; j++)
                {
                    if (Array[i] > Array[j])
                        {
                        Temp = Array[i];
                        Array[i] = Array[j];
                        Array[j] = Temp;
                        }
                }
            }
           
        }
        public static void Swap(ref string line1, ref string line2)
        {
            string Temp;
            Temp = line1;
            line1 = line2;
            line2 = Temp;
        }
        public static void Swap(ref int first, ref int second)
        {
            int Temp;
            Temp = first;
            first = second;
            second = Temp;
        }
        public static void Swap(ref double first, ref double second)
        {
            double Temp;
            Temp = first;
            first = second;
            second = Temp;
        }
        public static void Swap(ref decimal first, ref decimal second)
        {
            decimal Temp;
            Temp = first;
            first = second;
            second = Temp;
        }
        public static void Swap(ref byte first, ref byte second)
        {
            byte Temp;
            Temp = first;
            first = second;
            second = Temp;
        }
        public static void Swap(ref float first, ref float second)
        {
            float Temp;
            Temp = first;
            first = second;
            second = Temp;
        }
        public static string GetAddress(string city, string street, string houseNumber, string flatNumber)
        {
            string FullAdress;
            FullAdress = String.Format("г. {0}, ул. {1}, д. {2}, кв. {3}", city, street, houseNumber, flatNumber);
            return FullAdress;
        }
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
        public static int GetCountContains(string line, char symbol)
        {
            int quantity = 0;
            if (line == null)
            {
                return 0;
            }
            for (int i = 0; i < line.Length; i++)
            {
                if (line[i] == symbol)
                {
                    quantity++;
                }
            }

            return quantity;
        }
    }
}
