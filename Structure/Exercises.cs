using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
            if( x == 1)
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
        public static int FindSum(int[] array, int num)
        {
            int Sum = 0;
            if (num == 0)
            {
                return num;
            }
            return (Sum + array[num]) + FindSum(array, num -1);
        }

    }
}
//Console.WriteLine(FindSum([6,4,2,8,1], 4));


