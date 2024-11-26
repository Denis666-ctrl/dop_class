using System;

class ArrayOperations
{
    public static int[] SortAscending(int[] array)
    {
        Array.Sort(array);
        return array;
    }
    public static int[] SortDescending(int[] array)
    {
        Array.Sort(array);
        Array.Reverse(array);
        return array;
    }
    public static int[] MergeArrays(int[] array1, int[] array2)
    {
        int[] mergedArray = new int[array1.Length + array2.Length];
        Array.Copy(array1, mergedArray, array1.Length);
        Array.Copy(array2, 0, mergedArray, array1.Length, array2.Length);
        return mergedArray;
    }
}

class Program
{
    static void Main()
    {
        int[] array1 = { 5, 2, 8, 1 };
        int[] array2 = { 7, 3, 9, 4 };

        Console.WriteLine("Исходный массив 1:");
        Console.WriteLine(string.Join(", ", array1));

        Console.WriteLine("Исходный массив 2:");
        Console.WriteLine(string.Join(", ", array2));

        int[] sortedAscending = ArrayOperations.SortAscending((int[])array1.Clone());
        Console.WriteLine("\nМассив 1 после сортировки по возрастанию:");
        Console.WriteLine(string.Join(", ", sortedAscending));

        int[] sortedDescending = ArrayOperations.SortDescending((int[])array2.Clone());
        Console.WriteLine("\nМассив 2 после сортировки по убыванию:");
        Console.WriteLine(string.Join(", ", sortedDescending));

        int[] mergedArray = ArrayOperations.MergeArrays(array1, array2);
        Console.WriteLine("\nОбъединение массивов:");
        Console.WriteLine(string.Join(", ", mergedArray));
    }
}
