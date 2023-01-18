// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreatArray(int size)
{
    int[] createdArray = new int[size];
    return createdArray;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,30);
    }
}

string GetArrayInString(int[] array)
{
    return String.Join(",", array);
}

void PrintArray(int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int SumNumbers(int[] array)
{
    int sum = 0;

    for (int i = 1; i < array.Length; i = i + 2)
    {
        sum += array[i];
    }

    return sum;
}

int[] array = CreatArray(8);
FillArray(array);
PrintArray(array);
int sum = SumNumbers(array);
System.Console.WriteLine(sum);