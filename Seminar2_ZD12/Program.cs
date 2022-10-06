// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, является ли первое число кратным второму.
//Если число 1 не кратно числу 2, то программа выводит остаток от деления.


Console.Clear();

int a =0;
int b =0;

Console.WriteLine("Введите делимое"); 
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите делитель"); 
b = Convert.ToInt32(Console.ReadLine());

int r = a%b;
if (r==0)
{
    Console.WriteLine("Делится! Результат= "+ a/b);
}
else
{
    Console.WriteLine("Не делится, остаток= "+ r);
}