// Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное// 45->101101

Console.Clear();

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

string count = null;
while (number != 0)
{
    count += number % 2; // делим с остатком-если остатка от деления нет выведет 0
    number /= 2;
}
for (int i = count.Length - 1; i >= 0; i--) //В обратном порядке для разворота полученного двоичного числа
{
    Console.Write(count[1]);
}
