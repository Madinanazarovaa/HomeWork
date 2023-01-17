// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int[] CreateArray()
{
    System.Console.WriteLine("Введите колличество эллементов в массиве");
    int[] createArray = new int[Convert.ToInt32(Console.ReadLine())];
    return createArray;
}    

void FillArray(int[] array)
{
    int length = array.Length;
    int index = 0;
    while (index < length)
    {
        array[index] = new Random().Next(1, 100);
        index ++;
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    int position = 0;
    while(position < count)
    {
        System.Console.Write($"{array[position]} {" "}");
        position++;
    }
}
int[] array = CreateArray();
FillArray(array);
PrintArray(array);

