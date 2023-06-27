// Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
Console.Clear();
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
int[] array = GetArray(size, 100, 999);
int even = NumberEven(array);
Console.WriteLine(String.Join(", ", array));
Console.WriteLine($"Колличество четных чисел = {even}");

int[] GetArray(int optinon, int minval, int maxval)
{
    int[] arr = new int[optinon];
    for (int i = 0; i < optinon; i++)
    {
        arr[i] = new Random().Next(minval, maxval + 1);
    }
    return arr;
}
int NumberEven (int[] arr)
{
    int count = 0;
foreach (int el in arr)
    {
        if (el % 2 == 0)
        {
            count++;
        }
    }
    return count;
}