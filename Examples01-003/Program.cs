﻿// Даны два числа. Показать большее и меньшее числа.
Console.WriteLine("Введите последовательно два числа. Программа определит большее и меньшее из этих чисел ");
Console.WriteLine("Введите значение первого числа ");
double numberA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение второго числа ");
double numberB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите значение третьего числа ");
double numberC = Convert.ToDouble(Console.ReadLine());

double max = numberA;

if (numberA > max ) max = numberA;
if (numberB > max ) max = numberB;
if (numberC > max ) max = numberC;

Console.Write("Наибольшее число равно ");
Console.WriteLine(max);