﻿// Задача 11. Написать программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

Console.Clear();

int n = new Random().Next(100,999);
Console.WriteLine(n);

int first = n/100;// /100 используется для выявления первой цифры, int означает целое число(, по этому если например 753 /100= 7,53-53 выкидывается, остается 7)
int second = n%10; // %-означает остаток от деленея на 10(33/10 остаток 3 или 753/ 10=75,3-75 выкидывается, остаток от деления=3.д)
Console.WriteLine(first +""+ second);// кавычки идут в качестве пробела что бы числа не сложило