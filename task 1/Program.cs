/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.Clear();
Console.WriteLine("В ведите 1 число :");
int num1 = int.Parse(Console.ReadLine());
Console.WriteLine("В ведите 2 число :");
int num2 = int.Parse(Console.ReadLine());
int max = num1;

if (num2 > max) max = num2;

Console.WriteLine($"max= {max}");