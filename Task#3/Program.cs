// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76


float[] RandomArray()
{
    Random rnd = new Random();

    float[] array = new float[rnd.Next(2, 10)];

    for (int i = 0; i < array.Length; i++)
    {
        double num = Math.Round(rnd.NextDouble(), rnd.Next(1, 3));
        double whole = rnd.Next(0, 100);
        double count = num + whole;
        float number = (float)count;
        array[i] = number;
    }
    return array;
}

void PrintArray(float[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i]}\t");
    }
}

// float NegativeMinMax (float[] array)                // Можно разделить на 3 функции
// {
//     float min = array[0];
//     float max = array[0];
//     for (int i = 0; i < array.Length; i++)
//     {
//        if (min > array[i])
//        {
//         min = array[i];
//        }

//        if (max < array[i])
//        {
//         max = array[i];
//        } 
//     }
//     float diff = max - min;
//     return diff;
// }

float Max(float[] array)
{
    float max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (max < array[i])
        {
            max = array[i];
        }
    }
    return max;
}

float Min(float[] array)
{
    float min = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (min > array[i])
        {
            min = array[i];
        }
    }
    return min;
}

float Diff(float max, float min)
{
    float diff = max - min;
    
    return diff;
}

float[] myArray = RandomArray();

PrintArray(myArray);

System.Console.WriteLine();

System.Console.WriteLine($"\nРазница между Max({Max(myArray)}) и Min({Min(myArray)}) = {Diff(Max(myArray),Min(myArray))}");

// System.Console.WriteLine($"\nРазница между Max и Min = {NegativeMinMax(myArray)}");
