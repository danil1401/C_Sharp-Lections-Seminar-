//Задача 48. Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Amn=m+n. Введите полученный массив на экран.

Console.Clear();

Console.Write("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длину матрицы ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] mart)
{
    for (int i = 0; i < mart.GetLength(0); i++)
    {
        for (int j = 0; j < mart.GetLength(1); j++)
        {
            mart[i,j]=i+j;
        }
    }
}

void Print(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write(matr[i, j] + " ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Print(array);

