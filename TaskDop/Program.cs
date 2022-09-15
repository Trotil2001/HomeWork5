/*
Дана последовательность натуральных чисел 1, 2, 3, ..., N. Необходимо 
сначала расположить в обратном порядке часть этой последовательности 
от элемента с номером A до элемента с номером B, а затем от C до D
*/

int[] inputArray(int n)
{
int[] array= new int[n];
for (int i=0;i<array.Length;i++)
    array[i]=i+1;
return array;
}

Console.Write("Введите число N: ");
int n= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число A: ");
int a= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int b= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число C: ");
int c= Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число D: ");
int d= Convert.ToInt32(Console.ReadLine());
int tempA;

int[] array = inputArray(n);
Console.WriteLine("["+string.Join(", ", array) + "]");
int i = a-1, j=b-1;
while (i<=j)
{
    tempA=array[i];
    array[i]=array[j];
    array[j]=tempA;
    i++;
    j--;
}
i = c-1;
j=d-1;
while (i<=j)
{
    tempA=array[i];
    array[i]=array[j];
    array[j]=tempA;
    i++;
    j--;
}
Console.WriteLine("["+string.Join(", ", array) + "]");
