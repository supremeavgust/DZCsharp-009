// Задача 66: Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке 
// от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30
Console.Clear();
string OutPutNumber(int Number1, int Number2)

{
    if (Number1 == Number2)
        return Number1.ToString();
    return OutPutNumber(Number1, Number2 - 1) + ", " + Number2.ToString();

}
int SumInterval (int Number1, int Number2)
{
    if (Number1 == Number2) return Number1;
    else return Number1 + SumInterval(Number1 + 1, Number2);

}
Console.Write("vvedite chislo: ");
int[] numbers = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
Console.Write(OutPutNumber(numbers[0], numbers[1]));
    Console.WriteLine();
Console.WriteLine($"Сумма в этом промежутке составляет: {SumInterval(numbers[0], numbers[1])}");

