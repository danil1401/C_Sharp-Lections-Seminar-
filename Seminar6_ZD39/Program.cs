//Задача 39: Напишите программу, которая перевернет одномерный массив (последний элемент будет на певом месте, а первый - на последнем и т.д)
//[1, 2, 3] > [3, 2 ,1]
//РЕШЕНИЕ ПРЕПОДАВАТЕЛЯ
/*Console.Clear();

int[] array = new int[10];

Console.WriteLine("Ваш массив: ");
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 1000);
    Console.Write(array[i] + " ");
}

for (int i = 0; i < array.Length / 2; i++)// бежим в цикле до середины массива, меняя местами его элементы
{
    int t = array[i];
    array[i] = array[array.Length - i - 1];// меняем местами элементы массива
    array[array.Length - i - 1]=t;
}

Console.WriteLine();
Console.Write("Перевернутый массив: ");

for (int i =0 ; i<array.Length; i++)
{
    Console.Write(array[i] +" "); // + " " означает добавление пробела в качестве разделения между элементами массива
}
*/

//КРАСИВАЯ ВЕРСИЯ С КРАСИВЫМ КОДОМ (не работает с private static void ??)
/*Console.Write("Введите длину массива: ");
int countArr=Convert.ToInt32(Console.Readline());
int[] arr=new int [countArr];//присваиваем длину массива после введеного значения
RandomArray(arr, -20,21);//заполнение массива от [-20;21]
PrintArr(arr);//вывод массива
ReversArr(arr);// разворот массива
PrintArr(arr);//вывод массива


    void ReversArr (int[]arrs)
    {
        int count =0;
        for (int i=0;i<arr.Length/ 2;i++);
        {
            count=arr[i];
            arr[i]=arr[arr.Length-1-i];
            arr[arr.Length-i-1]=count;
        }
    }
    void PrintArr(int[]arrs)
    {
        Console.Write("Массив: {");
        for (int i =0;i<arr.Length;i++)
        {
            if (i!=arr.Length-1) Console.Write($"{arr[i]}, ");
            else Console.WriteLine(arr[i]+ "}");
        }
    }
    void RandomArray(int[]arrs, int min , int max)
    {
        Random random=new Random();
        for (int i=0;i<arr.Length;i++)
        {
            arr[i]=random.Next(min,max);
        }
    }*/
/////////////////////////////////РАБОЧИЙ ВАРИАНТ КРАСИВОГО КОДА(НАЙТИ В ЧЕМ ОШИБКА С ВЫШЕ НАПИСАННЫМ КОДОМ)
     Console.Write("Введите длину массива: ");
            
            int countArr = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[countArr];
            
            RandomArray(arr, -20, 21); // заполнение массива от [-20; 21).
            PrintArr(arr); // вывод массива
            ReversArr(arr); //разворот массива
            PrintArr(arr); // вывод массива
        
        
        void ReversArr(int[] arr)
        {
            int count;
            for (int i = 0; i < arr.Length / 2; i++)
            {
                count = arr[i];
                arr[i] = arr[arr.Length - 1 - i];
                arr[arr.Length - i - 1] = count;
            }
        }
        
        void PrintArr(int[] arr)
        {
            Console.Write("Массив: {");
            for (int i = 0; i < arr.Length; i++)
            {
                if(i != arr.Length - 1) Console.Write($"{arr[i]}, ");
                else Console.WriteLine(arr[i] + "}");
            }
        }
        
        void RandomArray(int[] arr, int min, int max)
        {
            Random random = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = random.Next(min, max);
            }
        }
    

