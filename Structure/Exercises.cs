using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Net.Http.Headers;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Structure
{
    internal static class Exercises
    {
        //ex 1
        public static int multyply(int x, int y)
        {
            if (x == 0)
            {
                return 0;
            }
            if (x == 1)
            {
                return y;
            }
            return y + multyply(x - 1, y);
        }

        //ex2
        public static int SumOfDigit(int x)
        {
            if (x < 10)
            {
                return x;
            }
            return x % 10 + SumOfDigit(x / 10);
        }

        //ex3
        public static int power(int x, int y)
        {
            if (x == 0)
            {
                return 1;
            }
            if (x == 1)
            {
                return y;
            }
            return y * power(x - 1, y);
        }

        //ex4
        public static int Reversed(int num)
        {
            return reserved(num, 0);
        }
        private static int reserved(int num, int newNum)
        {
            newNum *= 10;
            if (num < 10)
            {
                return newNum + num;
            }
            return reserved(num / 10, newNum + num % 10);
        }

        //ex5
        public static int FindSum(int[] array, int size)
        {
            int Sum = 0;
            if (size == 0)
            {
                return array[size];
            }
            return (Sum + array[size]) + FindSum(array, size - 1);
        }

        //ex6
        public static int divide(int a, int b)
        {
            if (a < b) return 0;
            return 1 + divide(a - b, b);
        }

        //ex7
        public static bool IsPalindrom(string palindrom)
        {
            return CheckPalindrome(palindrom, 0, palindrom.Length - 1);
        }
            
        private static bool CheckPalindrome(string s, int left, int right)
        {
            if (left >= right)
                return true;
            if (s[left] != s[right])
                return false;
            return CheckPalindrome(s, left + 1, right - 1);
        }

        //ex8
        public static string DecimalToBinary(int n)
        {
            if (n == 0)
                return "0";
            return DecimalToBinaryRecursive(n);
        }
        private static string DecimalToBinaryRecursive(int n)
        {
            if (n == 1)
                return "1";     
            return DecimalToBinaryRecursive(n / 2) + (n % 2).ToString(); 
        }

        //ex9
        public static int Gcd(int a, int b)
        {
            if (b == 0)
                return a;
            return Gcd(b, a % b);
        }

        //ex10
        public static void EvenNumbers(int even)
        {
            if (even <= 0)
              return;
            EvenNumbers(even - 1);
            if (even % 2 == 0)
                Console.WriteLine(even);
        }

        //ex11
        public static int FindMax(int[] nums, int idx)
        {            
            if (idx == nums.Length - 1)
            {
                return nums[idx];
            }
            int maxOfRest = FindMax(nums, idx + 1);
            return Math.Max(nums[idx], maxOfRest);
        }

        //ex12
        public static int SubtractEvenOdd(int num)
        {
            int lastDigit = num % 10;
            int evenSum = 0;
            int oddSum = 0;
            if (num == 0)
            {
                return 0;
            }
            if (lastDigit % 2 == 0)
            {
                evenSum = lastDigit;
            }
            else
            {
                oddSum = lastDigit;
            }
            int result = SubtractEvenOdd(num / 10);
            return result + evenSum - oddSum;
        }

        //ex13
        //public static bool sequence(int[] arr)
        //{

        //}

    }
}
//Console.WriteLine(FindSum([6,4,2,8,1], 4));


