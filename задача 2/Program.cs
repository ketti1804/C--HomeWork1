﻿/* Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3*/
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
if (numberA > numberB)
{ 
    Console.WriteLine($"Max:{numberA}");
    Console.WriteLine($"Min:{numberB}");
}
else if (numberA < numberB)
{ 
    Console.WriteLine($"Max: {numberB}");
    Console.WriteLine($"Min: {numberA}");
}
else { 
    Console.WriteLine("Числа равны");
}
