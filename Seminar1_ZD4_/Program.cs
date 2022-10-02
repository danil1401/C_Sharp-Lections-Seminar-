/* Напишети программу которая на вход принимает одно число (N) а на выходе показывает все целые числа в промежутке от -N до N
4-> "-4 -3 -2 -1 0 1 2 3 4"
2-> "-2 -1 0 1 2" */

Console.Write("Введите трехзначное число N: ");
int n=Convert.ToInt32(Console.Readline());
while (n<100|n>999)
{
Console.Write("Вы ввели недопустимое число, повторите ввод :");
    n=Convert.ToInt32(Console.ReadLine());
}
Console.Write ("Последняя цифра числа:"+Convert.ToString(n%10));
