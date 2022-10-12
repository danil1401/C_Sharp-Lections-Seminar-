//Задача 28. Напишите программу, которая принимает на вход число N и выдает произведение чисел от 1 до N

Console.Clear();

//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

Console.WriteLine("Введите число: ");
int N=int.Parse(Console.ReadLine());
int res=1;
int start=1;
while (start<=N)
{
    res=res*start;
    start++;
}
Console.WriteLine($"Произведение чисел числа {N} = {res}");


//РЕШЕНИЕ(Не работает почему то ) в ГРУППЕ
/*Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());

int result = addition(num);

int addition(int number)
{
    int count = 1;
    for (int i = 1; i <= number; i++)
    {
        count *= i; // либо записать count =count * i-одно и тоже
    }
    return count;
}

Console.WriteLine(result);*/