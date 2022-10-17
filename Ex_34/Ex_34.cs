// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] baseArray = GetArray(4, 100, 999);

Console.WriteLine($"Количество четных чисел в масиве [{String.Join(" ", baseArray)}] -> {String.Join(" ", ResultArray(baseArray))}");


int ResultArray (int[] array) // Метод подсчета четных чисел в массиве
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


int[] GetArray(int size, int minValue, int maxValue) // Метод создания случаного массива
{
    int[] result = new int[size];

    for (int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}