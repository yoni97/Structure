// See https://aka.ms/new-console-template for more information
using static Structure.Exercises;
using Structure;
using static Structure.Insertions;


//Console.WriteLine(Reversed(931));
//Console.WriteLine(FindSum([1,5,3], 3));
PrintArr.PrintArray(insertionSort([6,4,2,8,1]));
Console.WriteLine("");
PrintArr.PrintArray(SelectionSort([6,4,2,8,1]));
Console.WriteLine("");

Console.WriteLine(FindSum([6,4,2,8,1], 4));
//int num1 = 1;
//int num2 = 1;
//Console.WriteLine(num1 == num2);
////             0   1    2
//int[] arr1 = { 17, 80, 67 };
//int[] arr2 = { 1, 2 };
////Console.WriteLine(arr1 == arr2);
////Console.WriteLine(arr1[2]);

////Console.WriteLine(Array1.CalculateAverage());

//int size = 15;
//int[] arr20 = new int[size];
//Array1.InitArray(arr20);

//int num3 = 100;


//object[] generalArray = { 1, "Omer", 6.7, true };


////              variable    value
////                num1        1
////                num2        1
////                arr1       00x0    
////                arr2       00x8   



//// 00x0          arr1        17
//// 00x4                      80
//// 00x8                      67
//// 00x12         arr2         1
//// 00x12                      2



//// aliasing
//int num4 = 7;
//int num5 = num4;
//int[] myArr1 = { 5, 2, 99, 3 };
//int[] myArr2 = myArr1;
//myArr2[2] = -6;
//Console.WriteLine(myArr1[2]);
//// myArr1[4] = 4; // IndexOutOfRangeException: Index was outside the bounds of the array.


//Console.WriteLine("Starting ex1");

//int[] original = { 8, 9, 50, 13, 1000, -7 };
//Console.WriteLine("original is:");
//Array1.PrintArray(original);
////int[] reversed = Exercises.Ex1ReverseArray(original);
//Console.WriteLine("reversed is:");
////Array1.PrintArray(reversed);

