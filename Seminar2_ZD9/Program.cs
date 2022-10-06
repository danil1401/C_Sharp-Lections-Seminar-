//Задача 9. Написать программу, которая выводит случайное число из отрезка [10,99] и показывает наибольшую цифру числа
Console.Clear();

int n = new Random().Next(10,99); //метод рендом указывает что будет рандом из Некст интервала из 2х значений 10 и 99

Console.WriteLine(n);// печатает рандомное число н

int first = n/10; //10 используется для выявления первой цифры
int second = n%10; //%10 это остаток от деления
Console.WriteLine(first);
Console.WriteLine(second);

if (first>second)
{
    Console.WriteLine("Максимальное: "+first);
}
else
{
    Console.WriteLine("Минимальное: "+second);
}















/*Console.WriteLine("Введите ваше число: ");
int N = Convert.ToInt32(Console.ReadLine());

for (int i=1; i<=N; i++)
{
    if(i%2==0)
    Console.WriteLine(i);
}*/


/*Console.WriteLine("Задайте число m: ");
int m = int.Parse(Console.ReadLine());
Console.Write("Задайте число n: ");
int n = int.Parse(Console.ReadLine());

int Ackerman(int n, int m)
{
    if (n==0)
        return m+1;

}*/