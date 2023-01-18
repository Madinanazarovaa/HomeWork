// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

int[] CreatArray(int size)
{
    int[] createdArray = new int[size];
    return createdArray;
}

void FillArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-10,50);
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

int Difference(int[] array)
{
    int max = array[0];
    int min = array[0];
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] > max)
        {
            max = array[i];
        } 

        if(array[i] < min)
        {
            min = array[i];
        }
    }
    int difference = max - min;
    return difference;
}


int[] array = CreatArray(6);
FillArray(array);
PrintArray(array);
int difference = Difference(array);
System.Console.WriteLine(difference);