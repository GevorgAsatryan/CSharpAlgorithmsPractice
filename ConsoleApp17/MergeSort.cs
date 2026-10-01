using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public static class MergeSortType
    {
        public static int[] MergeSort(this int[] numbers)
        {
            if (numbers.Length < 2)
            {
                return numbers;
            }
            int middle = numbers.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[numbers.Length - middle];
           
            for (int i = 0; i < middle; i++)
            {
                left[i] = numbers[i]; 
            }
            int index = 0;
            for (int i = middle; i < numbers.Length; i++)
            {
                right[index] = numbers[i];
                index++;
            }

            left.MergeSort();
            right.MergeSort();

            int a = 0;
            int b = 0;

            //1,3,2,4
            //5,1,6,7
            //1,3,2,4

            index = 0;
            while (a < left.Length || b < right.Length)
            {
                if (a < left.Length && (b >= right.Length || left[a] <= right[b]))
                {
                    numbers[index] = left[a];
                    a++;
                    index++;
                }
                else if(b < right.Length && (a >= left.Length || left[a] > right[b]))
                {
                    numbers[index] = right[b];
                    b++;
                    index++;
                }
            }

            return numbers;
        }

    }
}
