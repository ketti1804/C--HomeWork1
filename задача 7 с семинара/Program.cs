/* Задача 7: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
456 -> 6
782 -> 2
918 -> 8*/
Console.Write("Введите трёхзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());
int length = num.ToString().Length;
int result = 0;
if (length == 3)
{ 
    result = num % 10;
    Console.WriteLine(result);
}
else {
    Console.WriteLine("Вы ввели не трёхзначное число, попробуйте снова.");
}
