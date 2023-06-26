// Задача 2: Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


int[] RandomArray()
{
    Random rnd = new Random();
    int[] myArray = new int[rnd.Next(4, 10)];

    for (int i = 0; i < myArray.Length; i++)
    {
        myArray[i] = rnd.Next(-100, 100);
    }
    return myArray;
}

int UserAmount(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if ((i+1) % 2 != 0)
        {
            summ = summ + (array[i]);
            
        }
    }
    return summ;
}

int ProgrammerAmount(int[] array)
{
    int summ = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0)
        {
            summ = summ + (array[i]);
        }
    }
    return summ;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

int[] myArray = RandomArray();


System.Console.WriteLine($"В массиве: \n");
PrintArray(myArray);
System.Console.WriteLine($"\nСумма не четных элементов массива глазами программиста = {ProgrammerAmount(myArray)}");
System.Console.WriteLine($"Сумма не четных элементов массива глазами пользывателя = {UserAmount(myArray)}");