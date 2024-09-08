namespace Structure;

public class Array1
{

    //ex1
    //6n + 3  = O(n)
    public static void CalculateOddSum(int[] array)
    {
        int SumOddNumbers = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 != 0)
            {
                SumOddNumbers += array[i];
            }
        }
        Console.WriteLine(SumOddNumbers);
    }

    //ex2 
    //6 + 9n = O(n)
    public static void FindMaximumTwo(int[] numbers)
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

    //ex2 a
    //8 + 13n = O(n)
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

    //ex3
    //2 + 5n = O(n)
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

    //ex4
    //9 + 14n**3 = O(n**3)
    static int SumOfAllTriplets(int[] array)
    {
        int len = array.Length;
        if (len < 3)
        {
            return 0;
        }
        int maxSum = int.MinValue;
        for (int i = 0; i < len - 2; i++)
        {
            for (int j = i + 1; j < len - 1; j++)
            {
                for (int k = j + 1; k < len; k++)
                {
                    int tripletSum = array[i] + array[j] + array[k];
                    if (tripletSum > maxSum)
                    {
                        maxSum = tripletSum;
                    }
                }
            }
        }
        return maxSum;
    }

    //ex5
    //4 + 10n**2 = O(n**2)
    public static int[] FindLastPairWithProduct(int[] array, int product)
    {
        for (int i = array.Length - 1; i > 0; i--)
        {
            for (int j = array.Length - 1; j > 0; j--)
            {
                if (array[j] * array[j - 1] == product)
                {
                    int[] twoNums = { array[j], array[j - 1] };
                    return twoNums;
                }
            }

        }
        return null;
    }

    //ex6
    //3 + 5n = O(n)
    public static int CountEvenNumbers(int[] array)
    {
        int count = 0;
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] % 2 == 0)
            {
                count++;
            }
        }
        return count;
    }

    //ex7
    //7 + 43n = O(n)
    public static int[] MergeSortedArraysUnique(int[] numbers1, int[] numbers2)
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
            else if (numbers1[num1] == numbers2[num2])
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
            if (merged[freeIndex] != numbers2[num1])
            {
                merged[freeIndex] = numbers1[num1];
                num1++;
                freeIndex++;
            }
        }
        while (num2 < numbers2.Length)
        {
            if (merged[freeIndex] != numbers2[num1])
            {
                merged[freeIndex] = numbers2[num2];
                num2++;
                freeIndex++;
            }
        }
        return merged;
    }

    //ex8
    //2 + 11n = O(n)
    public static void FindPairsWithSum(int[] array, int sum)
    {
        int count = 0;
        for (int i = 0; i < array.Length - 1; i++)
        {
            if (array[i] + array[i + 1] == sum)
            {
                Console.WriteLine($"pair {count} {array[i]} + {array[i + 1]} = {sum}");
                count++;
                Console.WriteLine("");
            }
        }
    }

    //ex9
    //5 + 13n = O(n)
    public static int[] CountFrequency(int[] array)
    {
        int[] ints = new int[array.Length];
        Dictionary<int, int> tempDict = new Dictionary<int, int>();
        for (int i = 0;i < array.Length;i++)
        {
            if (tempDict.ContainsKey(array[i]))
            {
                tempDict[array[i]]++;
            }
            else
            {
                tempDict[array[i]] = 1;
            }
        }
        for (int i = 0; i < tempDict.Count() ; i++)
        {
            ints[i] = tempDict[i];
        }
        return ints;
    }

    //ex10
    //6 + 12n = O(n)
    public static int FindMaxSubarraySum(int[] array)
    {
        int temp = array[0];
        int maxSum = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            if (array[i] > maxSum + array[i])
            {
                maxSum = array[i];
            }
            else
            {
                maxSum += array[i];
            }
            if (maxSum > temp)
            {
                temp = maxSum;
            }
        }
        return temp;
    }

    //ex11
    //5 + 9n**2 = O(n**2)  
    public static int FindFirstRepeating(int[] array)
    {
        int repeatNumber = array[0];
        for (int i = 1; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length; j++)
            {
                if (array[i] == array[j])
                {
                    return array[i];
                }
            }
        }
        return - 1;
    }

    //ex12
    //7 + 8n = O(n)
    public static int FindMissingNumberSortedArray(int[] array, int n)
    {
        if (array == null) return -1;
        if (array[0] != 1)
            return 1;
        
        for (int i = 1; i <= n ; i++)
        {
            if (array[i] + 1 != array[i + 1])
            {
                return array[i] + 1;
            }
        }
        return - 1;
    }

    //ex13
    //7 + 4n = O(n)
    public static int FindMissingNumberUnsortedArray(int[] array, int n)
    {
        bool[] temp = new bool[array.Length + 2];
        for (int i = 0; i < array.Length; i++)
            temp[array[i]] = true;
        for (int i = 1; i < temp.Length; i++)
            if (!temp[i])
                return i;
        return -1;
    }





    public static int[] buble(int[] array)
    {
        int temp = array[0];
        for (int i = 0; i < array.Length; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
        return array;
    }


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






    public static int[] reverse(int[] nums)
    {
        int[] result = new int[nums.Length];
        for (int i = 0; i < nums.Length; i++)
        {
            result[i] = nums[i - 1 - i];
            Console.WriteLine(result[i]);

        }
        return result;
    }

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












 

        



