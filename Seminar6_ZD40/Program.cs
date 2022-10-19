// Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины

Console.Clear();
Console.WriteLine("Введите 3 числа ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
int c = Convert.ToInt32(Console.ReadLine());
if (a + b > c && a + c > b && b + c > a)
{
    Console.WriteLine("Треугольник получился");
}
else
    Console.WriteLine("Треугольник не получился");
