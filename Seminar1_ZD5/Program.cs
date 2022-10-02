/* Напишети программу которая на вход принимает одно число (N) а на выходе показывает все целые числа в промежутке от -N до N
4-> "-4 -3 -2 -1 0 1 2 3 4"
2-> "-2 -1 0 1 2" */

Console.WriteLine("Введите число"); 
    int n = Convert.ToInt32(Console.ReadLine());
    int max = n;
    while (-n <=max) // В задаче используется метод while
    {
        Console.Write(-n + " ");
            n--;
    }

/*Та же задача с использованием метода FOR
int n = 0;
Console.WriteLine( "Введите число N" );
n = Convert.ToInt32(Console.ReadLine());;
for (int i = -n; i <= n; i++)
{
    Console.Write( i + " ");
}
*/