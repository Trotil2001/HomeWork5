/*
  Задача 34: Задайте массив заполненный случайными положительными 
  трёхзначными числами.     Напишите программу, которая покажет 
  количество чётных чисел в массиве.
  [345, 897, 568, 234] -> 2
  */
int evenNumbers = 0;
int[] array = new int[5];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    if (array[i] % 2 == 0) evenNumbers++;
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine("Четных числе " + evenNumbers);