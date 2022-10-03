/*Использование генератора псевдослучайных чисел и с использованием методов. 
Тренировка каким образом можно взять метод, 
передать его в массив и соответсвенно заполнить его нужным количеством элементов.
Метод который будет выводить все элементы по порядку
*/

void FillArray(int[] collection) //Даем название методу, в качестве аргумента будет приниматься "collection"
{
    int length = collection.Length; //тут нужно получить длину массива
    int index = 0; //Берем позицию индекса начиная с 0го
    while (index < length) // добавляем цикл, где пока индекс < length, будем что то делать
    {
        collection[index] = new Random().Next(1, 10); /* обращаемся к аргументу collection, на позицию index
        и положить туда новое случайное число из диапозона 1-10*/
        
        index++;//index = index +1;// в качестве что то делать
    }

}

void PrintArray(int[] col) // Метод void который будет печатать массив, в качестве аргумента тут будет "col"
{
    int count = col.Length; // тут количество элементов обозначим так
    int position = 0; // позицию обозначим не через переменную индекс а position
    while (position < count) // возьмем новый цикл while и скажем пока position < count, будем выводить на экран см. ниже
    {
        Console.WriteLine(col[position]);// значение текущего элемента
        position++;
    }

}

int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = 0;
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    }
    return position;
}
int[] array = new int[10]; /* задаем массив и указываем что в массиве по умолчанию будет 10 элементов. 
(new int[10]-создать массив в котором 10 элементов) */

FillArray(array);// будем тестировать наш массив, ЗАПОЛНЯТЬ НАШ МАССИВ-МЕТОД ЗАПОЛНЕНИЯ МАССИВА
PrintArray(array);// будет распечатывать наш массив. МЕТОД ПЕЧАТИ МАССИВА

Console.WriteLine();

int pos = IndexOf(array, 4);
Console.WriteLine(pos);