﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
    enum Gender
    {
        Man,
        Woman
    }

    enum CycleType
    {
        For,
        Foreach,
        While,
        DoWhile
    }
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

        public static void PrintArrayFor(int[] Array)
        {
            if (Array == null)
            {
                return;
            }
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

        public static void PrintArrayForEach(int[] Array)
        {
            if (Array == null)
            {
                return;
            }
            foreach (int i in Array)
            {
                Console.WriteLine(i);
            }
        }

        public static void PrintArrayWhile(int[] Array)
        {
            if (Array == null)
            {
                return;
            }
            int i = 0;
            while (i < Array.Length)
            {
                Console.WriteLine(Array[i]);
                i++;
            }
        }

        public static void PrintArrayDoWhile(int[] Array)
        {
            if ((Array == null) || (Array.Length == 0))
            {
                return;
            }
            int i = 0;
            do
            {
                Console.WriteLine(Array[i]);
                i++;
            }
            while (i < Array.Length);
        }

        public static bool Contains(int[] array, int value)
        {
            bool result = false;

            if (array == null)
            {
                return false;
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    result = true;
                    break;
                }
            }
            return result;
        }

        public static int GetIndex(int[] array, int value)
        {
            int result = -1;
            if (array == null)
            {
                return -1;
            }

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    result = i;
                }
            }
            return result;
        }

        public static void Copy(int[] from, int[] to)
        {
            if ((from == null) || (to == null))
            {
                return;
            }
            for (int i = 0; (i < to.Length) && (i < from.Length); i++)
            {
                to[i] = from[i];
            }
        }

        public static int[] CopyWithResize(int[] from, int[] to)
        {
            if ((from == null) || (to == null))
            {
                return null;
            }
            if (from.Length >= to.Length)
            {
                int[] CopyArrayResize = new int[from.Length];
                for (int i = 0; i < from.Length; i++)
                {
                    CopyArrayResize[i] = from[i];
                }
                return CopyArrayResize;
            }
            int[] CopyArray = new int[to.Length];
            for (int i = 0; i < from.Length; i++)
            {
                CopyArray[i] = from[i];
            }
            for (int i = from.Length; i < to.Length; i++)
            {
                CopyArray[i] = to[i];
            }
            return CopyArray;
        }

        public static void Clear(int[] array)
        {
            if (array == null)
            {
                return;
            }
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = 0;
            }
        }

        public static int[] Merge(int[] arrayFirst, int[] arraySecond)
        {
            if ((arrayFirst == null) || (arraySecond == null))
            {
                return null;
            }

            int[] MergeArray = new int[arrayFirst.Length + arraySecond.Length];
            for (int i = 0; i < arrayFirst.Length; i++)
            {
                MergeArray[i] = arrayFirst[i];
            }
            for (int i = arrayFirst.Length, j = 0; i < MergeArray.Length; i++, j++)
            {
                MergeArray[i] = arraySecond[j];
            }

            return MergeArray;
        }

        public static int[] Resize(int[] array, int newSize)
        {
            if (array == null)
            {
                return null;
            }
            int[] ResizeArray = new int[newSize];
            for (int i = 0; (i < ResizeArray.Length) && (i < array.Length); i++)
            {
                ResizeArray[i] = array[i];
            }
            return ResizeArray;
        }

        public static int[] RemoveByIndex(int[] array, int position)
        {
            if (array == null)
            {
                return null;
            }
            if ((position >= array.Length) || (position < 0))
            {
                return array;
            }
            int[] NewArray = new int[array.Length - 1];
            for (int i = 0, j = 0; i < NewArray.Length; i++, j++)
            {
                if (i == position)
                {
                    j++;
                }
                NewArray[i] = array[j];
            }
            return NewArray;
        }

        private static int GetQuantityOfValue(int[] array, int value)
        {
            int quantity = 0;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == value)
                {
                    quantity++;
                }
            }
            return quantity;
        }

        public static int[] RemoveByValue(int[] array, int value)
        {
            if (array == null)
            {
                return null;
            }
            int quantity = GetQuantityOfValue(array, value);
            int[] NewArray = new int[array.Length - quantity];
            for (int i = 0, j = 0; i < NewArray.Length; j++)
            {
                if (array[j] == value)
                {
                    
                    continue;
                }

                NewArray[i] = array[j];
                i++;
            }
            return NewArray;
        }

        public static string Welcome(string fullname, Gender gender)
        {
            string ResultWelcome = String.Empty;
            if (gender == Gender.Man)
            {
                ResultWelcome = String.Format("Уважаемый {0}, добро пожаловать!", fullname);
            }
            else
            {
                ResultWelcome = String.Format("Уважаемая {0}, добро пожаловать!", fullname);
            }
            return ResultWelcome;
        }

        public static void Print(int[] array, CycleType cycleType)
        {
            if (array == null)
            {
                return;
            }
            switch (cycleType)
            {
                case CycleType.For:
                    PrintArrayFor(array);
                    break;
                case CycleType.Foreach:
                    PrintArrayForEach(array);
                    break;
                case CycleType.While:
                    PrintArrayWhile(array);
                    break;
                case CycleType.DoWhile:
                    PrintArrayDoWhile(array);
                    break;
               
            }
        }
                
        public static int[,] InputMatrixFromConsol(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }


            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        } 

        static public void CountRowsAndColumns(int[,] matrix, out int rows, out int columns)
        {
            rows = matrix.GetUpperBound(0) + 1;
            columns = matrix.Length / rows;
        }

        public static bool FindByValue(int[,] matrix, int value, out int firstIndex, out int secondIndex)
        {
            firstIndex = -1;
            secondIndex = -1;
            if (matrix == null)
            {
                return false;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            bool result = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == value)
                    {
                        result = true;
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
            }
            return result;
            
        }

        public static void Clear(int[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;

                }
            }
        }

        public static int[,] Rotate90Def(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    NewMatrix[i, j] = matrix[rows - 1 - j, i];
                }
            }
            return NewMatrix;
        }

        public static bool isSquare(int[,] matrix)
        {
            if (matrix == null)
            {
                return false;
            }
            bool result = false;
            CountRowsAndColumns(matrix, out int rows, out int columns);
            if (rows == columns)
            {
                result = true;
            }
            return result;
        }

        public static int[] GetMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int size = 0;
            if (rows <= columns)
            {
                size = rows;
            }
            else
            {
                size = columns;
            }
            int[] Diagonal = new int[size];
            for (int i = 0; i < size; i++)
            {
                Diagonal[i] = matrix[i, i];
            }
            return Diagonal;
        }

        public static int[] GetSideDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int size = 0;
            if (rows <= columns)
            {
                size = rows;
            }
            else
            {
                size = columns;
            }
            int[] Diagonal = new int[size];
            for (int i = 0, j = 0; i < size; i++, j++)
            {
                Diagonal[i] = matrix[rows - 1 - i, j];
            }
            return Diagonal;
        }

        public static int SumMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return 0;
            }
            int sum = 0;
            int[] Diagonale = GetMainDiagonal(matrix);
            for (int i = 0; i < Diagonale.Length; i++)
            {
                sum = sum + Diagonale[i];
            }
            return sum;
        }

        public static int SumSideDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return 0;
            }
            int[] Diagonale = GetSideDiagonal(matrix);
            int sum = 0;
            for (int i = 0; i < Diagonale.Length; i++)
            {
                sum = sum + Diagonale[i];
            }

            return sum;

        }

        public static int[,] AddColumn(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[rows, columns + 1];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    NewMatrix[i, j] = matrix[i, j];
                }
            }
           
            return NewMatrix;
        }

        public static int[,] AddRow(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[rows + 1, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    NewMatrix[i, j] = matrix[i, j];
                }
            }
            return NewMatrix;
        }

        public static int[,] Resize(int[,] matrix, int countRows, int countColumn)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[countRows, countColumn];
            if (rows > countRows)
            {
                if (columns > countColumn)
                {
                    for (int i = 0; i < countRows; i++)
                    {
                        for (int j = 0; j < countColumn; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < countRows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
            }
            else
            {
                if (columns > countColumn)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < countColumn; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
            }
            return NewMatrix;
        }

        public static void SwapRow(int[,] matrix, int rowOne, int rowTwo)
        {
            if (matrix == null)
            {
                return;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            
            for (int j = 0; j < columns; j++)
            {
                Swap(ref matrix[rowOne, j], ref matrix[rowTwo, j]);
            }
        }

        public static void SwapColumns(int[,] matrix, int columnsOne, int columnsTwo)
        {
            if (matrix == null)
            {
                return;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            for (int i = 0; i < rows; i++)
            {
                Swap(ref matrix[i, columnsOne], ref matrix[i, columnsTwo]);
            }
        }

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

        public static char[] GetArrayOfEngRusLetters()
        {
            char[] EngAlphabet = GetEngAlphabet();
            char[] RusAlphabet = GetRusAlphabet();
            char[] AllLetters = new char[EngAlphabet.Length + RusAlphabet.Length];
            for (int i = 0; i < EngAlphabet.Length; i++)
            {
                AllLetters[i] = EngAlphabet[i];
            }
            for (int i = EngAlphabet.Length, j = 0; i < AllLetters.Length; i++, j++)
            {
                AllLetters[i] = RusAlphabet[j];
            }
            return AllLetters;
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

        public static void QSort(int[] array)
        {
            QSort(array, 0, array.Length - 1);
        }

        public static void QSort(int[] array, int left, int right)
        {
            if (left >= right)
            {
                return;
            }
            int pivot = left + (right - left) / 2;
            Sorting(array, left, right, pivot);
            QSort(array, left, pivot);
            QSort(array, pivot + 1, right);
            
        }

        public static void Sorting(int[] array, int left, int right, int pivot)
        {
            while (left < right)
            {
                if (array[left] < array[pivot])
                {
                    if (left < pivot)
                    {
                        left++;
                    }
                }
                else
                {
                    if (array[right] > array[pivot])
                    {
                        if (right > pivot)
                        {
                            right--;
                        }
                    }
                    else
                    {
                        Swap(ref array[left], ref array[right]);
                        left++;
                        right--;
                    }
                }
                
            }
            
        }


    }
}

  