/*Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22*/
Console.WriteLine("Введите первое число: ");
int numberA = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int numberB = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int numberC = int.Parse(Console.ReadLine());

if (numberA > numberB && numberA > numberC)
{ 
    Console.WriteLine($"Max:{numberA}");
}
else if (numberB > numberA && numberB > numberC)
{ 
    Console.WriteLine($"Max: {numberB}");
}
else if (numberC > numberA && numberC > numberA)
{ 
    Console.WriteLine($"Max: {numberC}");
}
else { 
    Console.WriteLine("Числа равны");
}