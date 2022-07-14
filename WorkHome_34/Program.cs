// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

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

int CountEvenNumbers(int[] numbers)
{
    int count = 0;
    
    for (int i = 0; i < numbers.Length; i++)
    {
        //int res = numbers[i] & 1;
        //if (res == 0)
        //if (numbers[i] / 2 * 2 == numbers[i])
        if (numbers[i] % 2 == 0)
        count ++;
    }
    return count;
}

int[] array = GetArrey(4, 100, 1000);
Console.Write($"[{string.Join(" ", array)}]\n");
CountEvenNumbers(array);
Console.WriteLine($"Чётных чисел: {CountEvenNumbers(array)}");
