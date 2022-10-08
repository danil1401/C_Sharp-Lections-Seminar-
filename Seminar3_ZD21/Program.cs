// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.

Console.Clear();

Console.WriteLine("Введите x1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите x2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Расстояние между координатами: " +Math.Sqrt((x1-x2)*(x1-x2)+(y1-y2)*(y1-y2)));// Квадратный корень