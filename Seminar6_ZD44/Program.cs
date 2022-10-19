//Задача 44: Не используя рекурсию, ввыведите первые N чисел Фибоначи. первые два числа Фибоначи 0 и 1

Console.Clear();

Console.WriteLine("Введите число: ");
int fib = Convert.ToInt32(Console.ReadLine());
Console.Write("0 1");

int first = 0;
int second = 1;
int next = 0;

for (int i = 1; i < fib - 1; i++)
{
    next = first + second;
    Console.Write(" " + next);
    first = second;
    second = next;
}

//////////РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ
/*int number=20;
int firstElem=1;
int secondElem=1;

Console.WriteLine("Последовательность фибоначчи");
Console.WriteLine($"1. {firstElem}");
Console.WriteLine($"2. {secondElem}");

for (int i=3;i<=number; i++)
{
    int nextElem=firstElem+secondElem;
    Console.WriteLine($"{i}. {nextElem}");
    firstElem= secondElem;
    secondElem=nextElem;
}*/