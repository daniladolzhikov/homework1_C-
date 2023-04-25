// Задача 2: Напишите программу, которая на вход принимает 
// два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число:");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число:");
int b = Convert.ToInt32(Console.ReadLine());
int max = 0;
int min = 0;
if (a > b)
{
    max = a;
    min = b;
    Console.WriteLine($"Max = {max}");
    Console.WriteLine($"Min = {min}");
}
else
{
    max = b;
    min = a;
    Console.WriteLine($"Max = {max}");
    Console.WriteLine($"Min = {min}");
}

