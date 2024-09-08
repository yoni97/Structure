//// See https://aka.ms/new-console-template for more information
using static Structure.Exercises;
using System;
using Structure;
using static Structure.Array1;

//using Newtonsoft.Json;
Console.WriteLine(FindMissingNumberSortedArray([1, 2,3,4,5,6,7,12], 8));
//BinaryTree tree = new BinaryTree();
//tree.Insert(6);
//tree.Insert(7);
//tree.Insert(8);
//tree.Insert(3);
//tree.Insert(10);
//tree.GetMin();
//Console.WriteLine("joker");
//Console.WriteLine();
//Console.WriteLine(FindSum([6, 4, 2, 8, 1], 4));


//BinaryTree tree = new BinaryTree();
//tree.Insert(50);
//tree.Insert(30);
//tree.Insert(70);
//tree.Insert(20);
//tree.Insert(40);
//tree.Insert(60);
//tree.Insert(80);
//tree.PostOrder();
//Console.WriteLine("");
//tree.PreOrder();
//Console.WriteLine("");
//tree.Delete(3);

//tree.InOrder();
//Console.WriteLine("");


//Console.WriteLine("Original tree:");
//tree.InOrder();
//Console.WriteLine();

//Console.WriteLine("Deleting 20:");
//tree.Delete(20);
//tree.InOrder();
//Console.WriteLine();

//Console.WriteLine("Deleting 30:");
//tree.Delete(30);
//tree.InOrder();
//Console.WriteLine();

//Console.WriteLine("Deleting 50:");
//tree.Delete(50);
//tree.InOrder();
//Console.WriteLine();


//static void Main()
//{

//    string data = File.ReadAllText(("C:\\Users\\User\\Desktop\\codcode\\c#\\consoleApp\\structures\\Structure\\Structure\\test.json"));
//    Dictionary<string, DataItem> dictionary = JsonSerializer.Deserialize<Dictionary<string, DataItem>>(data);

//    Dictionary<string, BinaryTree> trees = new();
//    foreach (DataItem model in dictionary.Values)
//    {
//        BinaryTree tree = new();
//        foreach (int num in model.t)
//        {
//            tree.Insert(num);
//        }
//        trees[model.n] = tree;
//    }
//    Console.WriteLine(trees["yoni"].GetMin());
//}
//Main();




//char[][] chars = new char[3][];
//for (int i = 0; i < 3; i++)
//{
//    for(int j = 0; j < 3; j++)
//    {
//        chars[i][j] = '_';
//    }
//}
//char player1 = 'x';
//char player2 = 'o';

//bool isWin = false;
//int rounds = 0;
//while (!isWin && rounds <= 9)
//{
//    Console.WriteLine("coordinates");
//    string input = Console.ReadLine();
//    switch (input)
//    {
//        case "0, 0":

//            break;
//    }
//}



//Console.WriteLine(Reversed(931));
//Console.WriteLine(FindSum([1, 5, 3], 3));
//PrintArr.PrintArray(insertionSort([6, 4, 2, 8, 1]));
//Console.WriteLine("");
//PrintArr.PrintArray(SelectionSort([6, 4, 2, 8, 1]));
//Console.WriteLine("");

////int num1 = 1;
////int num2 = 1;
////Console.WriteLine(num1 == num2);
//////             0   1    2
////int[] arr1 = { 17, 80, 67 };
////int[] arr2 = { 1, 2 };
//////Console.WriteLine(arr1 == arr2);
//////Console.WriteLine(arr1[2]);

//////Console.WriteLine(Array1.CalculateAverage());

////int size = 15;
////int[] arr20 = new int[size];
////Array1.InitArray(arr20);

////int num3 = 100;


////object[] generalArray = { 1, "Omer", 6.7, true };






////// aliasing
////int num4 = 7;
////int num5 = num4;
////int[] myArr1 = { 5, 2, 99, 3 };
////int[] myArr2 = myArr1;
////myArr2[2] = -6;
////Console.WriteLine(myArr1[2]);
////// myArr1[4] = 4; // IndexOutOfRangeException: Index was outside the bounds of the array.


////Console.WriteLine("Starting ex1");

////int[] original = { 8, 9, 50, 13, 1000, -7 };
////Console.WriteLine("original is:");
////Array1.PrintArray(original);
//////int[] reversed = Exercises.Ex1ReverseArray(original);
////Console.WriteLine("reversed is:");
//////Array1.PrintArray(reversed);
































































