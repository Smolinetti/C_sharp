// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

Console.WriteLine($"\nВозведене числа A в натуральную степень B");

int Exponentiation(int numberA, int numberB)
{
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result = result * numberA;
    }
    // int result = Math.Pow(numberA, numberB);
    return result;
}

Console.Write("Введите число A: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B: ");
int numberB = Convert.ToInt32(Console.ReadLine());

int exponentiation = Exponentiation(numberA, numberB);
Console.WriteLine("Ответ: " + exponentiation);


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

Console.WriteLine($"\nВывод суммы цифр в числе");
Console.Write("Введите число N: ");
int numberN = Convert.ToInt32(Console.ReadLine());

int SumNumber(int numberN)
{

    int counter = Convert.ToString(numberN).Length;
    int advance = 0;
    int result = 0;

    for (int i = 0; i < counter; i++)
    {
        advance = numberN - numberN % 10;
        result = result + (numberN - advance);
        numberN = numberN / 10;
    }
    return result;
}

int sumNumber = SumNumber(numberN);
Console.WriteLine("Сумма цифр в числе: " + sumNumber);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

Console.WriteLine($"\nЧисла преобразуем в массив");
Console.Write("Введите ряд чисел, разделенных запятой : ");
string? seriesOfNumbers = Console.ReadLine();

seriesOfNumbers = seriesOfNumbers + ",";

string RemovingSpaces(string series)
{
    string seriesNew = "";
    for (int i = 0; i < series.Length; i++)
    {
        if (series[i] != ' ')
        {
            seriesNew += series[i];
        }
    }
    return seriesNew;
}

void СheckNumber2(int series)
{

    if (series == '0' || series == '1' || series == '2'
    || series == '3' || series == '4' || series == '5' || series == '6'
    || series == '7' || series == '8' || series == '9' || series == ','
    || series == '-')
    {
    }
    else
    {
        Console.WriteLine($"Ошибка ввода  символа. Введите цифры.");

    }
}

int[] ArrayOfNumbers(string seriesNew)
{

    int[] arrayOfNumbers = new int[1]; 

    int j = 0;

    for (int i = 0; i < seriesNew.Length; i++)
    {
        string seriesNew1 = "";

        while (seriesNew[i] != ',' && i < seriesNew.Length)
        {
            seriesNew1 += seriesNew[i];
            СheckNumber2(seriesNew[i]);
            i++;
        }
        arrayOfNumbers[j] = Convert.ToInt32(seriesNew1);    
        if (i < seriesNew.Length - 1)
        {
            arrayOfNumbers = arrayOfNumbers.Concat(new int[] { 0 }).ToArray();    
        }
        j++;
    }
    return arrayOfNumbers;
}


void PrintArry(int[] coll)
{
    int count = coll.Length;
    int index = 0;
    Console.Write("[");
    while (index < count)
    {
        Console.Write(coll[index]);
        index++;
        if (index < count)
        {
            Console.Write(", ");
        }
    }
    Console.Write("]");
}


string seriesNew = RemovingSpaces(seriesOfNumbers);

int[] arrayOfNumbers = ArrayOfNumbers(seriesNew);

PrintArry(arrayOfNumbers);