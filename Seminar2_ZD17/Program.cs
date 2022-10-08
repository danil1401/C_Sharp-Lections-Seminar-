// Задача 17. Написать программу, которая принимает на вход координаты точки (Х и У), причем чХ не равно 0 и У не равно 0, 
// и выдает номер плоскости, в которой находится эта точка.

Console.Clear();

Console.WriteLine("Введиет x: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиет y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x>0 && y>0)
{
    Console.WriteLine(" 1 четверть ");
}
if (x<0 && y>0)
{
    Console.WriteLine(" 2 четверть ");
}
if (x<0 && y<0)
{
    Console.WriteLine(" 3 четверть ");
}
if (x>0 && y<0)
{
    Console.WriteLine(" 4 четверть ");
}