//Задача 30. Написать программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайный порядок

Console.Clear();

//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

int[] array = new int[8];
int len = array.Length;
int index = 0;
while (index < len)
{
    array[index] = new Random().Next(0, 2);
    index++;
}
for (int i = 0; i < len; i++)
{
    Console.Write(array[i]);
}





// РЕШЕНИЕ В ГРУППЕ
/*int[] arr = new int[8]; // Задаем массив с длиной в восемь

void newArray(int[] array) // Сделали невозвратную функцию void, мы в ней просто заполняем, ничего не возращая
{
    for (int i = 0; i < array.Length; i++) // с циклом fot от 0го элемента массива до последнего элемента массива (array.Length)
    {
        array[i] = new Random().Next(0, 2);
    }
}
void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}
newArray(arr); // вызываем функцию которая заполняет массив
PrintArray(arr); // вызываем функцию которая печатает массив
*/
