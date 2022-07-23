// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.

Console.Clear();
Console.WriteLine($"Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N, кратные трём.");
int n = InputNumbers("Введите n: ");
int m = InputNumbers("Введите m: ");
PrintNumber(n, m);
Console.Write(m);

void PrintNumber(int n, int m)
{
    if (m > n) return;
    PrintNumber(n, m + 1);
    Console.Write(m + ", ");
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}