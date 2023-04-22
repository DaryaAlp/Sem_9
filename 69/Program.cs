// Напишите программу, которая на вход принимает два числа A и B, и
// возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

using System;
using static System.Console;

Clear();
Write("Введите число: ");
int number = int.Parse(ReadLine());
Write("Введите число степени: ");
int pow = int.Parse(ReadLine());

WriteLine($"{PowNumbers(number, pow)}");
int PowNumbers(int number, int pow)
{
if (pow == 0)
return 1;
return PowNumbers (number, --pow)*number;
}