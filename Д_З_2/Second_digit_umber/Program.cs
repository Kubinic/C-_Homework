//Задача 10: Напишите программу, которая принимает 
//на вход трёхзначное число и на выходе показывает
//вторую цифру этого числа
Console.Write("Введите трёх-значное число : ");
int number = int.Parse(Console.ReadLine()!);
number = number % 100 / 10;
Console.Write(number);