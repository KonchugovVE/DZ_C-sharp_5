// Задача 1: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] RandomArray()
{
    Random rnd = new Random();
    int[] myArray = new int[rnd.Next(2, 10)];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(100, 1000);
    }
    return myArray;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int CountingEven(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        {
            count++;
        }
    }
    return count;
}


PrintArray(RandomArray());
System.Console.Write($"\nВ этом массиве, четных чисел => ");
System.Console.Write(CountingEven(RandomArray()));