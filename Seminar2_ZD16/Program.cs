//Задача 16. Напишите прогрпмму, которая принимает на вход два числа и проверяет, я вляется ли одно число квадратом другого.

Console.Clear();

Console.WriteLine("Введиет число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиет число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if(a*a==b || b*b==a) // ||-две палки значат "и/или"
{
    Console.WriteLine("Число является квадратом другого");
}
else
{
    Console.WriteLine("Ни одно число не является квадратом другого");
}

/*Решение Преподователя

Console.WriteLine("Введиет число a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введиет число b: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a*a==b)
{
    Console.WriteLine("b - квадрат a");
}
if
{
    Console.WriteLine("a - квадрат b");
}
else
{
    Console.WriteLine("не является b");
}
*/