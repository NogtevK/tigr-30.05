﻿/* Задача 67: Напишите программу, которая будет принимать на вход число и
возвращать сумму его цифр.
453 -> 12
45 -> 9 */

int Rec(int n)
{
    if (n == 0)
    {
        return 0;
    }
    Console.Write(" " + n % 10);
    return n % 10 + Rec(n / 10);
}

Console.Write(" -> "+Rec(453)+" ");