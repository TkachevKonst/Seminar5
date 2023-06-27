// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76
Console.Clear();
Console.WriteLine("Введите размер массива:");
int size = int.Parse(Console.ReadLine());
Console.WriteLine("Минимальное значение массива:");
int minvalue = int.Parse(Console.ReadLine());
Console.WriteLine("Максимальное значение массива:");
int maxvalue = int.Parse(Console.ReadLine());
double [] array = GetArray (size, minvalue, maxvalue);
PrintArray(array);
Console.WriteLine();
Console.WriteLine($" Разница между максимальным и минимальным значением = {MinMaxDiff (array):f2}");

double[] GetArray(int optinon, int minval, int maxval)
{
    double[] arr = new double[optinon];
    for (int i = 0; i < optinon; i++)
    {
        arr[i] = new Random().Next(minval,maxval)+ new Random().NextDouble();
    }
    return arr;
}
void PrintArray (double[]arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($" {arr[i]:f2}");
}
}
double MinMaxDiff (double[] arr)
{
double min = arr[0];
double max = arr[0];
foreach (double el in arr)
{
    if (el<min)
    {
        min=el;
    }
}
foreach (double el in arr)
{
    if (el>max)
    {
        max=el;
    }
}
double diff = max - min; 
return diff;
}
