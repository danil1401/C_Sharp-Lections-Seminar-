/*Напишите программу которая принимает на вход трехзначное число и на выходе показывает последнюю цифру этого числа.
456 ->6
782->2
918->8*/



Console.Write("Введите трехзначное число N: ");
int n=Convert.ToInt32(Console.ReadLine());
while (n<100|n>999) // Обозначает Логическое ИЛИ =|
                    //Логическое И= &
                    //Логическое НЕ= !
{
Console.Write("Вы ввели недопустимое число, повторите ввод :");
    n=Convert.ToInt32(Console.ReadLine());
}
Console.Write ("Последняя цифра числа:"+Convert.ToString(n%10));


/*Другое решение задачи
int N = 0;
Console.WriteLine("Введите трехзначное число:" );
N = Convert.ToInt32(Console.ReadLine());
if (N >= 100 && N <= 999)
{
    int lastDigit = N % 10;
    Console.WriteLine("Последняя цифра числа = " + lastDigit);
}
else
{
    Console.WriteLine("Это не трехзначное число!");
}
*/