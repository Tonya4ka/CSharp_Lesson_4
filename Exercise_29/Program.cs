// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран
Console.Clear();

int[] array = new int[8];
FillArray(array);
PrintArray(array);

void FillArray(int[] array)
{
    Random RandGen = new Random();
    for (int i = 0; i < 8; i++)
    {
        array[i] = RandGen.Next(0,100);
    }
}

void PrintArray(int[] array)
{
    int count = array.Length;
    Console.Write("[");
    for (int i = 0; i < count; i++)
    {
        Console.Write(array[i]);
        if (i == count - 1)
           Console.WriteLine("]");
        else
           Console.Write(",");
    }
}
