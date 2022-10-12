// Задача 26 Напишите программу, которая принимает на вход число и выдает колиество цифр в числе.

//РЕШЕНИЕ ПРЕПОДОВАТЕЛЯ
Console.Clear();

Console.WriteLine("Введите число");
int a = Convert.ToInt32(Console.ReadLine());
int count = 0;
while (a != 0)
{
    a = a / 10;
    count++;
}

Console.WriteLine(count);



/*АЛЬТЕРНАТИВНОЕ РЕШЕНИЕ
Console.WriteLine("Введите число");
int num = int.Parse(Console.ReadLine());// считываем с консоли и вводим значение в num

int count = 0;// здесь заводим переменную count- наш счетчик, нужна для того что бы считала сколько раз мы делили наше число

if (num==0)
{
    count=1;
}
else while (num!=0)// != означает не равно 0
{
    num=num/10;
    count++;
}*/


//Console.WriteLine(count);
