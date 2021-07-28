using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
   public static class SortService
    {
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
