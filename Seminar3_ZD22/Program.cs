//Задача 22 Напишите программу, которая принимает на вход число N и выдает таблицу квадрантов чисел от 1 до N.

Console.Clear();

//Console.WriteLine("Введите число N для отображения квадратов чисел от 1 до введеного значения: ");
//int N = Convert.ToInt32(Console.ReadLine());

/*   КОД УЧАСТНИКОВ
bool one = true;
while (one)

{
    try                                                 //try и catch - отлавливаем любые исключения из кода, так обрабатываются все ошибки
    {
        Console.WriteLine("Введит число N: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int index = 0;
        for (int i = 1; i<=num; i++)
        {
            index= (int)Math.Pow(i,2);// Math.Pow число i возводим в степень
            if(i==num) Console.Write(index + ".");
            Console.Write(index + ", ");
        }
        one=false;
    }
    catch
    {
Console.WriteLine("Ошибка ввода, введите еще раз");
    }
}*/

/*КОД ПРЕПОДОВАТЕЛЯ-не работает
Console.Write("Введит число N: ");
int N = Convert.ToInt32(Console.ReadLine());

for(int i=1;i<=N;i++)
{
    Write($"{i*i} ");
}*/
