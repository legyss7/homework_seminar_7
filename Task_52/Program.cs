/* Задача 52. Задайте двумерный массив из целых чисел. Найдите 
среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3. */


Console.Write("Введите размер m: ");
int m = int.Parse(Console.ReadLine() ?? String.Empty);
Console.Write("Введите размер n: ");
int n = int.Parse(Console.ReadLine() ?? String.Empty);

int[,] array =  CreatedArray(m, n);
PrintArr(array);
double[] arrayColumns = SumColumns(array);

Console.Write("Среднее арифметическое каждого столбца: ");
for (int i = 0; i < arrayColumns.Length; i++)
{
    Console.Write($"{Math.Round(arrayColumns[i], 1),5}");
}



int[,] CreatedArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    }
    return array;
}

void PrintArr(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


double[] SumColumns(int[,] ar)
{
    double[] arrColumns = new double[ar.GetLength(1)];

    for (int i = 0; i < ar.GetLength(1); i++)
    {
        for (int j = 0; j < ar.GetLength(0); j++)
        {
            arrColumns[i] += ar[j, i];
        }
        arrColumns[i] /= ar.GetLength(0);
    }
    return arrColumns;
}





