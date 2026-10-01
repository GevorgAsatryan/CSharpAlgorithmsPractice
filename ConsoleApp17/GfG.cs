using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17
{
    public static class GfG
    {

        // partition function
        public static int partition(int[] arr, int low, int high)
        {

            // choose the pivot
            int pivot = arr[high];

            // index of smaller element and indicates 
            // the right position of pivot found so far
            int i = low - 1;

            // traverse arr[low..high] and move all smaller
            // elements to the left side. Elements from low to 
            // i are smaller after every iteration
            for (int j = low; j <= high - 1; j++)
            {
                if (arr[j] < pivot)
                {
                    i++;
                    swap(arr, i, j);
                }
            }

            // move pivot after smaller elements and
            // return its position
            swap(arr, i + 1, high);
            return i + 1;
        }

        // swap function
        public static void swap(int[] arr, int i, int j)
        {
            int temp = arr[i];
            arr[i] = arr[j];
            arr[j] = temp;
        }

        // The QuickSort function implementation
        public static void quickSort(int[] arr, int low, int high)
        {
            Console.WriteLine("------------------------ new call quickSort()");
            Console.WriteLine($"low {low}");
            Console.WriteLine($"high {high}");
            if (low < high)
            {

                // pi is the partition return index of pivot
                int pi = partition(arr, low, high);
                Console.WriteLine($"Partition done {pi}");
                // recursion calls for smaller elements
                // and greater or equals elements
                quickSort(arr, low, pi - 1);
                quickSort(arr, pi + 1, high);
            }
        }
    }
}
