﻿/*Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
4 -> да
-3 -> нет
7 -> нет*/
Console.Clear();
Console.WriteLine("В ведите 1 число :");
int num1 = int.Parse(Console.ReadLine());
if (num1%2==0) 
Console.WriteLine("ДА");
else
{
Console.WriteLine("НЕТ");
}