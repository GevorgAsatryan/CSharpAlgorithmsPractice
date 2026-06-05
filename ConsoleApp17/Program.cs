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
            //foreach(var duplicate in Duplicates(numbers2))
            //{
            //    Console.WriteLine(duplicate);
            //}

            //Task 6
            //int[] numbers3 = { 1, 2, 3, 4, 5, 1, 4 };
            //TwoSum(numbers3, 5);

            //Task 7

            //int[] numbers4 = { 1, 3, 5, 2, 7, 6, 4 };
            //Console.WriteLine(FindTarget(numbers4, 2));

            //Task 8

            //int[] numbers5 = { 1, 2, 3, 4, 5 };
            //Console.WriteLine(BinarySearch(new int[]{ 1, 2, 3, 4, 5 }, 5));

            //Task 9

            //string parantheses = "()({[()]}[{}])";
            //Console.WriteLine(ValidateParentheses(parantheses));
            //Console.WriteLine(ValidateParentheses2(parantheses));

            //Task 10


        }

        //Task 1
        //Find the Largest Number

        public static int LargestNumber(int[] numbers)
        {
            int max = 0;
            foreach(var number in numbers)
            {
                if(number > max)
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
        //Find a Target in an Unsorted Array (after sorting)

        public static int FindTarget(int[] array, int target)
        {
            Array.Sort(array);
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == target)
                {
                    return i;
                }
            }
            return -1;
        }

        //Task 8
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

        //Task 9
        //Valid Parentheses

        //Version 1

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

        //Task 10

    }
}
