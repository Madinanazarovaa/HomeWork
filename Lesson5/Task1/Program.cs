// Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] CreateArray(int size)
{
    int[] createdArray = new int[size];
    return createdArray;
}

void FillArray(int[] array)
{
    Random rnd = new Random();
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
    }
}

string GetArrayInString(int[] array)
{
    return string.Join(",", array);
}

void PrintArray (int[] array)
{
    System.Console.WriteLine(GetArrayInString(array));
}

int EvenNumbers(int[] array)
{
    int storage = 0;
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        storage = array[i] % 10;
        if (storage % 2 == 0)
        {
             count++;
        }  
    }

    return count;
}

int[] array = CreateArray(4);
FillArray(array);
PrintArray(array);
int count = EvenNumbers(array);
System.Console.WriteLine(count);