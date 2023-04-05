// Задача 68: Напишите программу вычисления функции
// Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int Numb(int m, int n)
{
    if (m == 0)
    return n + 1;
    else if (n == 0)
    return Numb(m - 1, 1);
    else
    return Numb(m - 1, Numb(m, n - 1));
}

Console.Write("vvedite chislo M AND N: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(Numb(numbers[0], numbers[1]));
Console.WriteLine();