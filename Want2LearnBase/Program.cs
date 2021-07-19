﻿using System;
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

        public static int GetCountContains(string line, string word)
        {
            int quantity;
            string newLine = line.Replace(word, "");
            quantity = (line.Length - newLine.Length) / word.Length;
            return quantity;

        }

        public static string StringToNormal(string line, char seporator)
        {
            line = line.Trim(seporator);
            string DuplicateSep = new string(seporator, 2);
            string sep = new string(seporator,1);
            while (line.Contains(DuplicateSep))
            {
                line = line.Replace(DuplicateSep, sep);
            }
            return line;
        }

        public static string GetSubString(string line, int IndexStart, int IndexEnd)
        {
            string SubString = string.Empty;
            for (int i = IndexStart; i <= IndexEnd; i++)
            {
                SubString = SubString + line[i];

            }
            return SubString;
        }

        public static int[] GetIndexSeparator(string Line, char Seporator)
        {
           
            int count = GetCountContains(Line, Seporator);
            int[] ArrayInd = new int[count];
            for (int i = 0, j = 0; i < Line.Length; i++)
            {
                if (Line[i] == Seporator)
                {
                    ArrayInd[j] = i;
                    j++;
                }
            }
            return ArrayInd;
        }

        public static string[] MySplit(string line, char seporator)
        {
            if (line == null || line == String.Empty)
            {
                return null;
            }

            line = StringToNormal(line, seporator);
            int[] IndexesSeporators = GetIndexSeparator(line, seporator);
            int countWords = IndexesSeporators.Length + 1;
            string[] resultArray = new string[countWords];

            resultArray[0] = GetSubString(line, 0, IndexesSeporators[0] - 1);
            resultArray[resultArray.Length - 1] = GetSubString(line, IndexesSeporators[IndexesSeporators.Length - 1] +1, line.Length - 1);
            for (int i = 0, j = 1; i < IndexesSeporators.Length - 1; i++, j++)
            {
                resultArray[j] = GetSubString(line, IndexesSeporators[i] + 1, IndexesSeporators[i + 1]);
            }
            return resultArray;
        }

        public static char[] GetRusAlphabet()
        {
            int size = 66;
            int indexEndSmall = 32;
            int indexOfyo = 6;
            int indexBeginLarge = 33;
            int indexOfYO = 39;

            char[] Alphavit = new char[size];
            for (int i = 0, j = (int)'а'; i <= indexEndSmall; i++, j++)
            {
                if (i == indexOfyo)
                {
                    Alphavit[i] = 'ё';
                    i++;
                }
                Alphavit[i] = (char)(j);
            }
            for (int i = indexBeginLarge, j = (int)'А'; i <= Alphavit.Length - 1; i++, j++)
            {
                if (i == indexOfYO)
                {
                    Alphavit[i] = 'Ё';
                    i++;
                }
                Alphavit[i] = (char)(j);
            }
            return Alphavit;
        }

        public static void ToLowerCase(ref string WordFirst, ref string WordSecond)
        {
            WordFirst = WordFirst.ToLower();
            WordSecond = WordSecond.ToLower();
        }

        private static void SortCharArray(char[] Array)
        {
            char Temp;
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

        public static bool IsAnagram(string wordFirst, string wordSecond)
        {
            bool IsAnagram;
            ToLowerCase(ref wordFirst, ref wordSecond);
            char[] WordFirst = wordFirst.ToCharArray();
            char[] WordSecond = wordSecond.ToCharArray();
            SortCharArray(WordFirst);
            SortCharArray(WordSecond);
            string FirstWord = new string(WordFirst);
            string SecondWord = new string(WordSecond);
            IsAnagram = String.Compare(FirstWord, SecondWord) == 0 ? true : false;
            return IsAnagram;
        }

        public static char[] GetEngAlphabet()
        {
            int size = 52;
            int j = 0;
            char[] Alphabet = new char[size];
            for (char i = 'a'; i <= 'z'; i++, j++)
            {
                Alphabet[j] = i;
            }
            for (char i = 'A'; i <= 'Z'; i++, j++)
            {
                Alphabet[j] = i;
            }
            return Alphabet;
        }

        private static string ReverseString(string word)
        {
            char[] Word = word.ToCharArray();
            Array.Reverse(Word);
            string RevWord = new string(Word);
            return RevWord;
        }

        public static bool IsPalindrome(string word)
        {
            if (word == null || word == String.Empty)
            {
                return false;
            }
            word = word.ToLower();
            string ReverseWord = ReverseString(word);
            bool Palindrome = word == ReverseWord;
            return Palindrome;
        }

    }
}
