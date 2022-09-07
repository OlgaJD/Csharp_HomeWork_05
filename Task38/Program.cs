// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

void DifNumbers()
{
    Console.Write("Введите длину массива: ");
    int n = Convert.ToInt32(Console.ReadLine());
    double[] array = new double[n];
    for (int i = 0; i < array.Length; i++)
    {
        double x = new Random().Next(-100, 101);
        double y = new Random().Next(1, 10);
        array[i] = Math.Round(x / y, 2);
        Console.Write($"{array[i]},  ");
    }
    Console.WriteLine();
    double max = array[0];
    double min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Максимальное = {max}");
    Console.WriteLine($"Минимальное = {min}");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {max - min}");
}
DifNumbers();
