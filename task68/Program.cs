// Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int GetNumber(string message)
{
    int result;
    while (true)
    {
        System.Console.Write(message);
        if (int.TryParse(Console.ReadLine(), out result) && result >= 0)
            break;
        else System.Console.WriteLine("Введено ненатуральное число. Задайте натуральное число :");
    }
    return result;
}

int AckermanFunction(int m, int n)
{
    if (m == 0)
        return n + 1;
    else if (m != 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    return AckermanFunction(m - 1, AckermanFunction(m, n - 1));
}
Console.Clear();
int m = GetNumber($"Введите число m: ");
int n = GetNumber($"Введите число n: ");
System.Console.WriteLine("$ A(m,n) = " + AckermanFunction(m, n));
