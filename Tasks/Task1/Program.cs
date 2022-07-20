﻿// Задайте значения M и N. Напишите программу, которая выведет все чётные натуральные числа в промежутке от M до N с помощью рекурсии.
// M = 1; N = 5 -> "2, 4"
// M = 4; N = 8 -> "4, 6, 8"

int Prompt(string message)
{
    System.Console.Write(message);
    return int.Parse(Console.ReadLine());
}

void PrintNatural(int n, int m)
{
    for (int i = n; i <= m; i++)
    {
        if (i % 2 == 0)
    System.Console.Write($" {i}");
            return;
    }
    PrintNatural(n - 1, m);
}


int n = 10;
int m = 5;
PrintNatural(n, m);



