﻿// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");

//zad1
static int AverageOfArray(int[] arr)
{
    int sum2 = 0;
    foreach (int num in arr)
    {
        sum2 += num;
    }
    return sum2 / arr.Length;
}
//zad2
static int MaxOfArray(int[] arr)
{
    int max = arr[0];
    foreach (int num in arr)
    {
        if (num > max)
            max = num;
    }
    return max;
}

