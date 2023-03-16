/*
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30

*/

//Задайте значения M и N. Напишите программу, которая найдёт сумму 
//натуральных элементов в промежутке от M до N.


using System;
using static System.Console;
Clear();

int Prompt(string message)
{
    Write(message);
    int num_result = int.Parse(ReadLine()!);
    return num_result;
}

int SumNumbers(int start, int end)
{
    if (start == end) return start;
    return (start + SumNumbers(start + 1, end));
}

int m = Prompt("Введите число M: ");
int n = Prompt("Введите число N: ");

WriteLine($"Cумма натуральных элементов от {m} до {n} = {SumNumbers(m, n)}");


