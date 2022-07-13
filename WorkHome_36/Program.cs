// Задача 36: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.Clear();

int[] GetArrey(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
    return array;
}

void OddPositionsSum(int[] collect)
{
        int oddNumbersSum = 0;

    for (int i = 0; i < collect.Length; i ++)
    {
        if (i % 2 != 0) oddNumbersSum += collect[i];     
    }
    Console.WriteLine("Сумма элементов на нечетных позициях: " + oddNumbersSum);
}

int[] array = GetArrey(4, -10, 20);
Console.Write($"[{string.Join(" ", array)}]\n");
OddPositionsSum(array);
