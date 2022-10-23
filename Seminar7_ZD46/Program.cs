//Задача 46 Задайте двумерный массив рпзмером m*n, заполненный случайными числами.


Console.Clear();

Console.Write("Введите высоту матрицы: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Введите длину матрицы ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

void FillArray(int[,] mart) // Метод заполнения массива
{
    for (int i = 0; i < mart.GetLength(0); i++) // цикл поиска количества для строк
    {
        for (int j = 0; j < mart.GetLength(1); j++) // цикл поиска количества для столбцов
        {
            mart[i, j] = new Random().Next(1, 10); // тут мы кладем уже рандомное значение в строки и столбцы
        }
    }
}

void Print(int[,] matr) // нужно понять зачем этот метод? Печатает
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
