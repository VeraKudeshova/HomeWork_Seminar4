﻿// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//Не используя Math.Pow!    //3, 5 -> 243 (3⁵)      //2, 4 -> 16

Console.WriteLine("Введите первое число ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число ");
int b = int.Parse(Console.ReadLine());

int s = a;

for (int i = 1; i < b; i++)
{
    s = s * a;
}
Console.WriteLine("a в степени b равно: " + s);
