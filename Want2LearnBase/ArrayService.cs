using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
   public enum CycleType
    {
        For,
        Foreach,
        While,
        DoWhile
    }
    public static class ArrayService
    {
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
    }
}
