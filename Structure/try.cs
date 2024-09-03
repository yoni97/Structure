using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Structure;

public class Array1
{

    // a few ways to define arrays

    // 1 define an empty array with the size and type
    // bad
    public static int[] array1 = new int[10];
    public static char[] charArray = new char[10]; // default value '\0'

    //good
    public static int peopleAmount = 10;
    public static int[] ages = new int[peopleAmount];


    // 2 define an array hard coded
    public static int[] array2 = { 67, -7, 0, 50 };
    public static string[] names = { "Omer", "Avi", "Yakov" };

    public static double CalculateAverage()
    {

        int[] arr = { 1, 2, 3, 4, 5 };
        int len = arr.Length;
        double sum = 0;
        for (int i = 0; i < len; i++)
        {
            sum += arr[i];
        }
        double average = sum / len;
        return average;
    }

    public static void InitArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = i;
        }
    }


    public static void PrintArray(int[] arr)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write(arr[i] + " ");
        }
        Console.WriteLine();
    }

    public static void CalculateOddSum(int[] array)
    {
        int SumOddNumbers = 0;
        for (int i = 0;i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                SumOddNumbers += array[i];
            }
        }
        Console.WriteLine(SumOddNumbers);
    }

    public static void twoMaxNum(int[] numbers)
    {
        int n1 = numbers[0];
        int n2 = numbers[1];
        for (int i = 2; i < numbers.Length; i++)
        {
            if (n1 < i)
            {
                n1 = numbers[i];
            }
            if (n2 < i && i != n1)
            {
                n2 = numbers[i];
            }
        }
        Console.WriteLine((n1, n2));
    }


    public static void twoMaxAndCloseNums(int[] numbers)
    {
        int num1 = int.MinValue;
        int num2 = int.MinValue;
        int max = numbers[0] + numbers[1];
        for (int i = 0; i < numbers.Length; i++)
        {
            int j = i + 1;
            if (numbers[i] + numbers[j] > max)
            {
                max = numbers[i] + numbers[j];
                num1 = numbers[i]; 
                num2 = numbers[j];
            }
            
        }
        Console.WriteLine((num1, num2));
    }

    public static void ContainsNumber(int[] array, int number)
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] == number)
            {
                Console.WriteLine(true);
            }
        }
        Console.WriteLine(false);
    }


    //public static int[] FindLastClosePairWithProduct(int[] array, int product)
    //{
    //    for (int i = 0; i < array.Length - 1; i++)
    //    {
    //        if ()
    //    }
    //}



    public static int[] FindLastPairWithProduct(int[] array, int product)
    {
        for (int i = array.Length -1; i > 0; i--)
        {
            for (int j = array.Length - 1; j > 0; j--)
            {
                if (array[j] * array[j - 1] == product)
                {
                    int[] twoNums = {array[j], array[j - 1]};
                    return twoNums;
                }
            }
            
        }
        return null;
    }

    public static int[] buble(int[] array)
    {
        int temp = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if ( array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }
















    //public static int[] reverse(int[] nums)
    //{
    //    int[] result = new int[nums.Length];
    //    for (int i = 0; i < nums.Length; i++)
    //    {
    //        result[i] = nums[i-1-i];
    //        Console.WriteLine(result[i]);

    //    }
    //    return result;
    //}

    int[] arr1 = { 1, 2, 3, 4, 5, 3, 2, 3, };


        int[] numbers = { 1, 2, 3, 4, 5 };
        public static void sumOfIntegers(int[] numbers)
        {
            int sum = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                sum += numbers[i];
            }
            Console.WriteLine(sum);
        }

        public static int minNumber(int[] numbers)
        {
            int minNum = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (i > i + 1)
                {
                    minNum = numbers[i];
                }
            }
            return minNum;
        }

        public static (int, int) twoMinNum(int[] numbers)
        {
            int n1 = numbers[0];
            int n2 = numbers[1];
            for (int i = 2; i < numbers.Length; i++)
            {
                if (n1 > i)
                {
                    n1 = numbers[i];
                }
                if (n2 > i && i != n1)
                {
                    n2 = numbers[i];
                }
            }
            return (n1, n2);
        }

        public static int[] mergeArray(int[] numbers1, int[] numbers2)
        {
            int num1 = 0;
            int num2 = 0;
            int freeIndex = 0;
            int[] merged = new int[numbers1.Length + numbers2.Length];
            while (num1 < numbers1.Length && num2 < numbers2.Length)
            {
                if (numbers1[num1] < numbers2[num2])
                {
                    merged[freeIndex] = numbers1[num1];
                    num1++;
                }
                else
                {
                    merged[freeIndex] = numbers2[num2];
                    num2++;
                }
                freeIndex++;
            }
            while (num1 < numbers1.Length)
            {
                merged[freeIndex] = numbers1[num1];
                num1++;
                freeIndex++;
            }
            while (num2 < numbers2.Length)
            {
                merged[freeIndex] = numbers2[num2];
                num2++;
                freeIndex++;
            }
            return merged;
        }


        public static int[] getTimes(int[] numbers)
        {
            int[] newArr = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                int index = 0;
                for (int j = 0; i + j < numbers.Length; j++)
                {
                    if (numbers[j] == numbers[i])
                    {
                        index++;
                    }
                }
                newArr[i] = index;
            }
            return newArr;
        }
    }
        //static int[] merge(int[] arr1, int[] arr2)
        //{
        //    int i1 = 0; 
        //    int i2 = 0;
        //    int len = arr1.Length + arr2.Length;
        //    int[] ans = new int[len];
        //    while (i1 + i2 < len)
        //    {
        //        if (arr1[i1] < arr2[i2])
        //        {
        //            ans[i1 + i2] = arr1[i1++];
        //        }
        //        if (arr2[i2] < arr1[i1])
        //        {
        //            ans[i1 + i2] = arr2[i2++];
        //        }
        //    }
        //}












 

        



