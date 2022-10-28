/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.WriteLine("Введите число M:");
int userNumberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N:");
int userNumberN = Convert.ToInt32(Console.ReadLine());
int sum = GetSum(userNumberM, userNumberN);
Console.WriteLine(sum);

int GetSum(int startPoint, int endPoint)
{
    if (startPoint == endPoint+1)
    {
        return 0;
    } 
    return startPoint + GetSum(startPoint+1, endPoint);
}
