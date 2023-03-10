﻿// Задача 65: Задайте значения M и N. 
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 6, 7, 8"

void RoadToN(int max, int min )
{
    if(max < min)
    {
        return;
    }
    RoadToN(max-1,min);
    System.Console.Write($"{max} ");
}

System.Console.Write("Введите число max: ");
int numberMax = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите число min: ");
int numberMin = Convert.ToInt32(Console.ReadLine());
RoadToN(max:numberMax,min:numberMin);