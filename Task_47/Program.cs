/* Задача 47. Задайте двумерный массив размером m×n, заполненный случайными 
вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9 */

Console.Write("Введите размер m: ");
int m = int.Parse(Console.ReadLine() ?? String.Empty);
Console.Write("Введите размер n: ");
int n = int.Parse(Console.ReadLine() ?? String.Empty);

double[,] arr = new double[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = Math.Round(new Random().NextDouble() * new Random().Next(-9, 10), 1);
    }
}

void PrintArr(double[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 7}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

PrintArr(arr);


