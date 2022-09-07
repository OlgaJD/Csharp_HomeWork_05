// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.Write("Введите длину массива: ");
void Sum()
{
    int n = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[n];
    int count = 0;
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-100, 101);
        if (i != array.Length - 1) Console.Write($"{array[i]}, ");
        else Console.Write($"{array[i]}");
        int num = array[i] % 2;
        if (num != 0)
        {
            int a = array[i];
            count++;
            sum = sum + a;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"Всего нечетных позиций в массиве {count}");
    Console.WriteLine($"Сумма нечетных позиций в массиве {sum}");
}
Sum();
