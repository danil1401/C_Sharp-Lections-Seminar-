// 1. Написать программу которая на вход принимает два числа и проверяет является ли первое число квадратом второго

Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите третье число");
int c = Convert.ToInt32(Console.ReadLine());

if (a > b) 
{
    Console.WriteLine("Первое число больше");
}
else
{
    if (b > c)
    {
    Console.Write("Второе число больше");
    }
    else 
    {
        Console.Write("Третье число больше");
    }
}

//a=25, b=5 ->да
//a=2, b=10 -> нет
//a=9, b= -3 ->да
//a=-3, b= 9 ->нет


/*Console.WriteLine("Введите первое число");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int a = Convert.ToInt32(Console.ReadLine());

if (n == a*a)
{
    Console.WriteLine("Да");
}
else
{
    Console.Write("Нет");
}*/

/*Console.WriteLine("Введите первое число");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
{
    Console.WriteLine("Первое число больше");
}
else
{
    Console.Write("Второе число больше");
}*/