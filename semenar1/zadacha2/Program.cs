﻿// напишите программу,которая будет выдавать название дня недели по заданному номеру.
// 3-> среда
// 5 -> пятница

Console.WriteLine("Введите номер дня недели");
int num1 = Convert.ToInt32(Console.ReadLine());
if (num1 == 1)
{
    Console.WriteLine("понедельник");
}
else if (num1 == 2)
{
    Console.WriteLine("Вторник");
}
else if (num1 == 3)
{
    Console.WriteLine("Среда");
}
else if (num1 == 4)
{
    Console.WriteLine("Четверг");
}
else if (num1 == 5)
{
    Console.WriteLine("Пятница");
}
else if (num1 == 6)
{
    Console.WriteLine("Суббота");
}
else if (num1 == 7)
{
    Console.WriteLine("Воскресенье");
}
