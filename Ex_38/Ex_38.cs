// Задайте массив вещественных чисел(просто от минус бесконечности, до плюс бесконечности, с дробными не работаем). 
// Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76


int[] baseArray = GetArray(10, -100, 100);

Console.WriteLine($"Разница между максимальным и минимальным элементов массива [{String.Join(" ", baseArray)}] -> {String.Join(" ", ResultArray(baseArray))}");


int ResultArray (int[] array) // Метод подсчета разницы между максимальным и минимальным элементов массива
{
    int result = 0;
    int max = 0;
    int min = int.MaxValue;
    for (int i = 0; i < array.Length; i++)
    {
       if (array[i] > max)
       {
        max = array[i];
       }
       if (array[i] < min)
       {
        min = array[i];
       }
    }
    result = max - min;
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