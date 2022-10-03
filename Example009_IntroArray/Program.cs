int Max(int arg1, int arg2, int arg3) // берем несколько аргументов
{
    int result = arg1;
    if(arg2>result) result =arg2;
    if(arg3>result) result =arg3;
    return result; // Что бы метод возращал резалт
}
///////////////0  1  2  3  4  5  6  7  8
int[] array = {11,21,31,41,15,61,17,18,19}; // Стока ОПРЕДЕЛЯЕТ МАССИВ "int[] array"
//array[0] = 12; // обращение к элементу массима под индексом 0 и присваивание ему значения 12
int result= Max(
    Max(array[0], array[1], array[2]),
    Max(array[3], array[4], array[5]),
    Max(array[6], array[7], array[8])
);
Console.WriteLine(result);

/*int max1 = Max(a1, b1, c1);
int max2 = Max(a2, b2, c2);
int max3 = Max(a3, b3, c3);

int max = Max( max1, max2, max3);

Console.WriteLine(max);*/