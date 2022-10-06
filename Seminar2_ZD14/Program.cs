// Задача 14. Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.Clear();

Console.WriteLine("Введиет число: ");
int a = Convert.ToInt32(Console.ReadLine());

if (a%7 ==0 && a%23==0)
{
    Console.WriteLine("Число кратно 7 и 23 ");

}
else
{
    Console.WriteLine("Число не кратно 7 и 23 ");
}


/*Решение Преподователя
Console.WriteLine("Введиет число: ");
int n = Convert.ToInt32(Console.ReadLine());

bool ismultiplicity(int a)
{
    return (a%7 ==0 & a%23==0);
}
if (ismultiplicy(n))
{
    Console.WriteLine("Делится!");
}
else
{
    Console.WriteLine("Не делится");
}*/