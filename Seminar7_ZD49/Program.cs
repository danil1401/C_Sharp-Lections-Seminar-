//Задача 49. Задайте двумерный массив. Найдите элементы, у которых оба индекса четные, и замените эти элементы на их квадраты
// Задача 51. Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали.

Console.Clear();

Console.Write("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длину матрицы ");
int n = int.Parse(Console.ReadLine());

int[,] matr = new int[m, n];

void Fill(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(1, 10);
        }
    }
}

Fill(matr);
Console.WriteLine();
Console.WriteLine("Исходная матрица: ");
Print(matr);

for (int i = 0; i < matr.GetLength(0); i += 2)
{
    for (int j = 0; j < matr.GetLength(1); j += 2)
    {
        matr[i, j] = i + j;
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

Console.WriteLine("Измененная матрица: ");
Print(matr);
