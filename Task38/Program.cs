/*
    Задача 38: Задайте массив вещественных чисел. Найдите разницу 
    между максимальным и минимальным элементов массива.
    [3 7 22 2 78] -> 76

*/

int[] inputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
    return array;
}

int minArray(int[] array)
{
    int minElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < minElem)
            minElem = array[i];
    }
    return minElem;
}
int maxArray(int[] array)
{
    int maxElem = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxElem)
            maxElem = array[i];
    }
    return maxElem;
}
int[] matrix = new int[6];
int[] arr = inputArray(matrix);

Console.WriteLine("[" + string.Join(", ", arr) + "]");
Console.WriteLine(maxArray(arr) - minArray(arr));
