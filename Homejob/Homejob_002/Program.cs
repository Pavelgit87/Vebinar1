﻿Console.WriteLine("Ведите первое число ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите второе число ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Ведите третье число ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > max) max = number2;
if (number3 > max) max = number3;

Console.Write("max = " );
Console.WriteLine(max);



