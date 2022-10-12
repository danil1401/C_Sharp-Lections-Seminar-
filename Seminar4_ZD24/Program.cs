// Задача 24. Напишите программу, которая принимает на вход число (А) и выдает сумму чисел от 1 до А.

Console.Clear();

Console.WriteLine("Введите число");

int A = int.Parse(Console.ReadLine()); // Parse= Convert.ToInt32(Console.Readline());-можно и то и то использовать

int sum = 0;
for (int i = 1; i <= A; i++)

{
    sum = sum + i;
}
Console.WriteLine($"Сумма от 1 до {A}: {sum}"); //доллар-мы внедряем в троку именна переменных
