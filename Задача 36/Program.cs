// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0
Console.Clear();
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Минимальное значение массива:");
int minvalue = int.Parse(Console.ReadLine());
Console.WriteLine("Максимальное значение массива:");
int maxvalue = int.Parse(Console.ReadLine());
int[] array = GetArray(size, minvalue, maxvalue);
Console.WriteLine(String.Join(", ", array));
int sumnumber = SumEl(array);
Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {sumnumber}");



int[] GetArray(int optinon, int minval, int maxval)
{
    int[] arr = new int[optinon];
    for (int i = 0; i < optinon; i++)
    {
        arr[i] = new Random().Next(minval, maxval + 1);
    }
    return arr;
}
int SumEl(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum += arr[i];
        }
    }
    return sum;
}