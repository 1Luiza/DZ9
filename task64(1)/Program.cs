/*
Задайте значение M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N. 
Выполнить с помощью рекурсии.

M = 1; N = 5 -> 1, 2, 3, 4, 5
*/

Console.WriteLine("Введите число M:");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int userNumberN = Convert.ToInt32(Console.ReadLine());
PrintRange(userNumberM, userNumberN);

void PrintRange(int startPoint, int endPoint)
{
    if(startPoint == endPoint)
    {
        Console.Write($"{endPoint}, ");
        return;
    }
    PrintRange(startPoint, endPoint - 1);
    Console.Write($"{endPoint}, ");
}

