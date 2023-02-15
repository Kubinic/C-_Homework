//Задача 4: Напишите программу, которая принимает на вход 
//три числа и выдаёт максимальное из этих чисел.
Console.Write("Введите число 1 : ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2 : ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3 : ");
int number3 = int.Parse(Console.ReadLine()!);
int max = 0;
if (max < number1) max = number1;
if (max < number2) max = number2;
if (max < number3) max = number3;

Console.Write(max);