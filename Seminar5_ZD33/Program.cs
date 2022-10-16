// Задача 33. Задайте массив. Напишите программу, которая определяет присутсвует ли заданное число в массиве.

Console.Clear();

int[] array = {1, 2, 3 ,4};
Console.WriteLine ("введите число ");
int elem=Convert.ToInt32(Console.ReadLine());
int len = array.Length;
bool isThere= false;

for(int i=1;i<len;i++)
{
    if (array[i]==elem)
    {
        isThere=true;
    }
}

if (isThere)
{
    Console.WriteLine (" Да, элемент присутсвует в массиве ");
}

else
{
    Console.WriteLine ("Нет, элемент не присутсвует в массиве");
}
