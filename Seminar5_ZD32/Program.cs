// Задача 32. Напишите программу замена элементов массива: положительные элементы замените на соответсвующие отрицательные и наоборот.

Console.Clear();

//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ

int [] array = {1, 2, 3, 4};
int len =array.Length;

Console.WriteLine();
Console.Write("Измененный масси: ");

for (int i=0;i<len;i++)
{
    array[i] *=-1;
    Console.Write(array[i] + " ");
}

/*РЕШЕНИЕ НА СЕМИНАРЕ
//Заполнение массива минимальным и максимальным
int[] array = new Int32[4];

randomFilling(array, min:-9, max:10);
arrayOutput(array);
int[] randomFilling(int[] arr, int min, int max);


{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = new Random().Next(min, max);
    }

    return arr;
}

//Задаем функцию печати
void arrayOutput(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}");
        if (i < (arr.Length - 1)) Console.Write($", ");
    }
}
*/