// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");
Console.WriteLine("1");
Console.WriteLine("2");
Console.WriteLine("3");

//zad1
static int AverageOfArray(int[] arr)
{
    int sum = 0;
    foreach (int num in arr)
    {
        sum += num;
    }
    return sum / arr.Length;
}
