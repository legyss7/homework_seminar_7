/* Задача 50. Напишите программу, которая на вход принимает позиции 
элемента в двумерном массиве, и возвращает значение этого элемента 
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
1 7 -> такого числа в массиве нет
1 1 -> 9 */

Console.Write("Введите размер m: ");
int m = int.Parse(Console.ReadLine() ?? String.Empty);
Console.Write("Введите размер n: ");
int n = int.Parse(Console.ReadLine() ?? String.Empty);

int[,] arr = new int[m, n];

for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
    }
}
PrintArr(arr);

Console.Write("Введите индексы элемента двумерного массива (через запятую): ");
string[] str = (Console.ReadLine() ?? String.Empty).Split(",");
int row = Convert.ToInt32(str[0]);
int column = Convert.ToInt32(str[1]);

if(row > (m-1) || column > (n-1)) Console.Write($"[{row}, {column}] такого числа в массиве нет.");
else Console.Write($"[{row}, {column}] -> {arr[row, column]}");



void PrintArr(int[,] array)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{array[i, j], 5}");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}



