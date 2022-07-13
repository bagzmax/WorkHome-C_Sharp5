//Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.Clear();

double[] GetArrey(int size, int minValue, int maxValue)
{
    double[] array = new double[size];

    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().NextDouble() * (maxValue-minValue)+minValue;
        array[i] = Math.Round(array[i],1);
    }
    return array;
}

double SearchMaxValue(double[] massiv)
{
    double maxValue = massiv[0];

    for (int i = 1; i < massiv.Length; i++) 
    {
        if (massiv[i] > maxValue)
        {
            maxValue = massiv[i];
        }
    }
    Console.WriteLine($"maxValue = {maxValue}");
    return maxValue;
}

double SearchMinValue(double[] massiv)
{
    double minValue = massiv[0];

    for (int i = 1; i < massiv.Length; i++) 
    {
        if (massiv[i] < minValue)
        {
            minValue = massiv[i];
        }
    }
    Console.WriteLine($"minValue = {minValue}");
    return minValue;
}

Console.Write($"Введите число,задающее размер массива: ");
int size = int.Parse(Console.ReadLine()!);

double[] array = GetArrey(size, -10, 20);
Console.Write($"Заданный массив: [{string.Join(" ", array)}]\n");

double deciesionMaxMinValue = Math.Round((SearchMaxValue(array)) - (SearchMinValue(array)), 1);
Console.Write($"Разница между MaxValue и MinValue = {deciesionMaxMinValue}");