﻿// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 / [-4, -6, 89, 6] -> 0

int[] baseArray = GetArray(4, 0, 100);

Console.WriteLine($"Сумма элементов стоящих на нечетных позициях в массиве [{String.Join(" ", baseArray)}] -> {String.Join(" ", ResultArray(baseArray))}");

int ResultArray (int[] array) // Метод подсчета суммы элементов на нечетных позициях
{
    int result = 0;
    for (int i = 1; i < array.Length; i = i + 2)
    {
        if (i % 2 != 0)
        {
            result = result + array[i];
        }
    }
    return result;
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