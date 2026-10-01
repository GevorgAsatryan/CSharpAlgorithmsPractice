using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ConsoleApp17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //int[] numbers1 = { 4, 1, 3, 2, 0 , 1, 3};
            //Console.WriteLine(LargestNumber(numbers1));

            //Task 2
            //string word1 = "programming";
            //Console.WriteLine(VowelsCount(word));

            //Task 3
            //string word2 = "Hello";
            //Console.WriteLine(ReverseString(word2));

            //Task 4
            //var word3 = "racecar";
            //Console.WriteLine(Palindrome(word3));
            //Console.WriteLine(Palindrome(word2));

            //Task 5
            //int[] numbers2 = { 1, 7, 3, 4, 6, 2, 6, 7 };
            //foreach (var duplicate in GetDuplicates(numbers2))
            //{
            //    Console.WriteLine(duplicate);
            //}

            //Task 6
            //int[] numbers3 = { 1, 2, 3, 4, 5, 1, 4 };
            //TwoSum(numbers3, 5);

            //Task 7

            //int[] numbers5 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(BinarySearch(new int[]{ 1, 2, 3, 4, 5 }, 5));

            //Task 8

            //string parantheses = "()({[()]}[{}])";
            //Console.WriteLine(ValidateParentheses(parantheses));
            //Console.WriteLine(ValidateParentheses2(parantheses));

            //Task 9

            //string substring = "abccba";
            //Console.WriteLine(GetNumberOfLongestSubstring(substring));

            //Task 10

            //int[][] intervals = [[1, 2], [2, 3], [3, 4]];

            //foreach(var i in MergeIntervals(intervals))
            //{
            //    Console.WriteLine($"[{i[0]}, {i[1]}]");
            //}

            //Get Removable Indices

            //string str1 = "aaaab";
            //string str2 = "aaaa";

            //foreach(var a in GetRemovableIndices(str1, str2))
            //{
            //    Console.WriteLine(a);
            //}

            //Console.WriteLine(Collatz(134379));
            //for (int i = 134378; i <= 140000; i++)
            //{
            //    bool result = Collatz(i);

            //    if (result)
            //        Console.WriteLine(i + ": true");
            //    else
            //        throw new Exception($"{i}");
            //}

            //Quick Sort

            long startMemory = GC.GetAllocatedBytesForCurrentThread();

            int[] numbers = new int[] {0, 2, 5, 1, 6, 3, 4, 10, 2, 3, 5, 4, 8 };
            //GfG.quickSort(numbers, 0, numbers.Length - 1);

            numbers.MergeSort();
            //numbers = numbers.QuickSort();
            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            };
            long auxiliarySpaceUsed = GC.GetAllocatedBytesForCurrentThread() - startMemory;

            Console.WriteLine($"Space used: {auxiliarySpaceUsed} bytes");
        }

        //Task 1
        //Find the Largest Number

        public static int LargestNumber(int[] numbers)
        {
            int max = 0;
            foreach (var number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            return max;
        }

        //Task 2
        //Count Vowels

        public static int VowelsCount(string word)
        {
            int count = 0;
            foreach(var w in word)
            {
                switch (w)
                {
                    case 'a':
                        count++;
                        break;
                    case 'e':
                        count++;
                        break;
                    case 'i':
                        count++;
                        break;
                    case 'o':
                        count++;
                        break;
                    case 'u':
                        count++;
                        break;
                }
            }
            return count;
        }

        //Task 3
        //Reverse a String

        public static string ReverseString(string word)
        {
            string reversed = "";

            for(int i = word.Length - 1; i >= 0; i--)
            {
                reversed += word[i];
            }
            return reversed;
        }

        //Task 4
        //Palindrome Check

        public static bool Palindrome(string word)
        {
            if (word.Equals(ReverseString(word)))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //Task 5
        //Find Duplicates

        public static IEnumerable<int> Duplicates(int[] numbers)
        {
            HashSet<int> seen = new HashSet<int>();
            
            foreach(var number in numbers)
            {
                if (!seen.Add(number))
                {
                    yield return number;
                }
            }

        }

        //Task 6
        //Two Sum

        public static void TwoSum(int[] numbers, int target)
        {
            Dictionary<int, int> seen = new Dictionary<int, int>();

            for(int i = 0; i < numbers.Length; i++)
            {
                int a = target - numbers[i];
                if (seen.ContainsKey(a))
                {
                    Console.WriteLine($"[{seen[a]};{i}]");
                }

                seen.TryAdd(numbers[i], i);

            }
        }

        //Task 7
        //Binary Search

        public static int BinarySearch(int[] array, int target)
        {
            int left = 0;
            int right = array.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (array[mid] == target)
                {
                    return mid;
                }
                else if (array[mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        //Task 8
        //Valid Parentheses

        //Version 1

        //irakanacnel quicksort algoritmy
        //yndunum e zangvac ev elementnery dasavorum ajman kargov

        public static bool ValidateParentheses(string parentheses)
        {
            Stack<char> openingParentheses = new Stack<char>();
           
            foreach (var p in parentheses)
            {
                if (p == '(' || p == '{' || p == '[')
                {
                    openingParentheses.Push(p);
                }
                else
                {
                    if(openingParentheses.Count == 0)
                    {
                        return false;
                    }

                    char opening = openingParentheses.Pop();

                    if (p == ')' && opening != '(' || p == '}' && opening != '{' || p == ']' && opening != '[')
                    {
                        return false;
                    }
                }
            }
            
            return openingParentheses.Count == 0;
        }

        //Version 2

        public static bool ValidateParentheses2(string parentheses)
        {
            Stack<char> opening = new Stack<char>();

            Dictionary<char, char> pairs = new Dictionary<char, char>()
            {
                { ')', '(' }, 
                { '}', '{' },
                { ']', '[' }
            };


            foreach (var p in parentheses)
            {
                if(p == '(' || p == '{' || p == '[')
                {
                    opening.Push(p);
                }
                else
                {
                    if(opening.Count == 0 || opening.Pop() != pairs[p])
                    {
                        return false;
                    }
                }
            }

            return opening.Count == 0;
        }

        //Task 9
        //Longest Substring Without Repeating Characters

        public static int GetNumberOfLongestSubstring(string substring)
        {
            Dictionary<char, int> pairs = new Dictionary<char, int>();
            int count = 0;
            int left = 0;

            for(int right = 0; right < substring.Length; right++)
            {
                if (pairs.ContainsKey(substring[right]) && pairs[substring[right]] >= left)
                {
                    left = pairs[substring[right]] + 1;
                }

                pairs[substring[right]] = right;
                count = Math.Max(count, right - left + 1);
            }
            return count;
        }

        //Task 10
        //Merge Intervals

        public static int[][] MergeIntervals(int[][] intervals)
        {
            var result = new List<int[]>();

            if(intervals == null || intervals.Length == 0)
            {
                return [];
            }

            Array.Sort(intervals, (a ,b) => a[0].CompareTo(b[0]));
            int[] current = intervals[0];

            for (int i = 1; i < intervals.Length; i++)
            {
                if (current[1] >= intervals[i][0])
                {
                    current[1] = Math.Max(current[1], intervals[i][1]);
                }
                else
                {
                    result.Add(current);
                    current = intervals[i];
                }
            }
            result.Add(current);

            return result.ToArray();
        }

        //Get Removable Indices

        public static List<int> GetRemovableIndices(string str1, string str2)
        {
            var result = new List<int>();
            var sb = new StringBuilder();

            if (str1.Length != str2.Length + 1)
            {
                return new List<int> { -1 };
            }
            for(int i = 0; i < str1.Length; i++)
            {
                for (int j = 0; j < str1.Length; j++)
                {
                    if (j != i)
                    {
                        sb.Append(str1[j]);
                    }
                }
                if (str2 == sb.ToString())
                {
                    result.Add(i);
                }
                sb.Clear();
            }
           
            return result;
        }

        public static int[] GetDuplicates(int[] numbers)
        {
            List<int> duplicates = new List<int>();
            HashSet<int> seen = new HashSet<int>();
            for(int i = 0; i < numbers.Length; i++)
            {
                if (!seen.Add(numbers[i]))
                {
                    duplicates.Add(numbers[i]);
                }
            }
            int[] result = duplicates.ToArray();
            return result;
        }

        static bool Collatz(int n)
        {
            while (n != 1)
            {
                if (n % 2 == 0)
                {
                    n /= 2;
                    Console.WriteLine("even");
                }
                else
                {
                    n = 3 * n + 1;
                    Console.WriteLine("odd");
                }
            }

            return true;
        }
    }

}
