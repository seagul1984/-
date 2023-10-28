// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int GetNumber(string message)
{
    int result;
    while (true)
    {
        System.Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else System.Console.WriteLine("Введено ненатуральное число. Задайте натуральное число :");
    }
    return result;
}

int GetSum(int m, int n)
{
    int sum = 0;
    if (m == n)
        return n;
    if (m < n)
        return sum += (m + GetSum(m + 1, n));
    return 0;
}
Console.Clear();
int m = GetNumber($"Введите число М: ");
int n = GetNumber($"Введите число N: ");
System.Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N {m} до {n}:  {GetSum(m, n)}");