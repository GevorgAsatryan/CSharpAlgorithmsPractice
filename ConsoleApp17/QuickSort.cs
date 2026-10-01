using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp17
{
    public static class Sort
    {
        public static int[] QuickSort(this int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return numbers;
            }

            int pivot = numbers[numbers.Length - 1];
            numbers = Partition(numbers);
            var pivotIndex = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < pivot)
                {
                    pivotIndex++;
                }
            }
            int[] left = new int[pivotIndex];
            int[] right = new int[numbers.Length - pivotIndex - 1];

            for (int i = 0; i < pivotIndex; i++)
            {
                left[i] = numbers[i];
            }
            var index = 0;
            for (int i = pivotIndex + 1; i < numbers.Length; i++)
            {
                right[index] = numbers[i];
                index++;
            }

            left = left.QuickSort();
            right = right.QuickSort();

            var indexResult = 0;
            foreach (var number in left)
            {
                numbers[indexResult] = number;
                indexResult++;
            }
            numbers[indexResult] = pivot;
            indexResult++;
            foreach (var number in right)
            {
                numbers[indexResult] = number;
                indexResult++;
            }

            return numbers;
        }

        public static int[] Partition(int[] numbers)
        {
            int pivot = numbers[numbers.Length - 1];

            int[] copy = new int[numbers.Length];
            int index = 0;
            int pivotCount = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < pivot)
                {
                    copy[index] = numbers[i];
                    index++;
                }
                else if (numbers[i] == pivot)
                {
                    pivotCount++;
                }
            }

            for (int i = 0; i < pivotCount; i++)
            {
                copy[index] = pivot;
                index++;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] > pivot)
                {
                    copy[index] = numbers[i];
                    index++;
                }
            }

            return copy;
        }
        //2, 1, 5, 3, 4      4, 4, 0, 0, 0

        //2, 1, 1, 2, 3, 3, 5, 4, 5, 4
        //2, 1, 1, 2, 3, 3, 5, 5, 4, 4

        // 1, 2, 3, 4, 5









        //int first = 0;
        //int last = numbers.Length - 1;
        //int i = first - 1;
        //int temp = 0;
        //for (int j = 0; j < last; j++)
        //{
        //    if (numbers[j] < pivot)
        //    {
        //        i++;
        //        temp = numbers[i];
        //        numbers[i] = numbers[j];
        //        numbers[j] = temp;
        //    }
        //}
        //temp = numbers[i + 1];
        //numbers[i + 1] = pivot;
        //numbers[numbers.Length - 1] = temp;

        ////int[] a = numbers;
        //return i + 1;

    }
}
