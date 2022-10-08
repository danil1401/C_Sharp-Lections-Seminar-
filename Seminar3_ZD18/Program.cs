//Задача 18 Напишите программу, которая по заданному номеру четверти, показывает диапозон возможных координат точек в этой четверти (х и у)

Console.Clear();

Console.WriteLine("Введите номер четверти от 1 до 4: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n==1)
{
   Console.WriteLine("Возможные координаты x>0 & y>0 ");
}
else if (n==2)
{
   Console.WriteLine("Возможные координаты x<0 & y>0 ");
}
else if (n==3)
{
   Console.WriteLine("Возможные координаты x<0 & y<0 ");
}
else if (n==4)
{
   Console.WriteLine("Возможные координаты x>0 & y<0 ");
}

if ( n<1|n>4)
{
    Console.WriteLine("Введено не корректное значение ");
}