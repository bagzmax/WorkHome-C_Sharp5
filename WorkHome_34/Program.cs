// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

Console.Clear();

int[] GetArrey(int size, int minValue, int maxValue)
{
    int[] array = new int[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue + 1);
    }
    return array;
}

void FindEvenNumbers(int[] numbers)
{
    int count = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] / 2 * 2 == numbers[i])
        count ++;
    }
    Console.WriteLine("Четных чисел: " + count);
}

int[] array = GetArrey(4, 1, 1000);
Console.Write($"[{string.Join(" ", array)}]\n");
FindEvenNumbers(array);