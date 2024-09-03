using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structure
{
    //Console.WriteLine(insertionSort([6,4,2,8,1]));

    internal static class Insertions
    {
        public static int[] insertionSort(int[] arr)
        {
            int i, j;
            for (i = 1; i < arr.Length; i++)
            {
                j = i - 1;
                int temp = arr[i];
                while (j >= 0 && arr[j] > temp)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = temp;
            }
            return arr;
        }

        //public static void SelectionSort(int[] arr)
        //{
        //    int len = arr.Length;
        //    for (int i = 0; i < len; i++)
        //    {
        //        int temp = arr[i];
        //        for (int j = i + 1; j < len; j++)
        //        {
        //            if (arr[j] < temp)
        //            {
        //                arr[j] = temp;

        //            }
        //        }
        //        arr[]
        //    }
        //}



        public static int[] SelectionSort(int[] arr)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                int min = i;
                for (int j = i + 1; j < len; j++)
                {
                    if (arr[j] < arr[min])
                    {
                        min = j;
                    }
                }
                int temp = arr[i];
                arr[i] = arr[min];
                arr[min] = temp;                
            }
            return arr;
        }
    }
}
