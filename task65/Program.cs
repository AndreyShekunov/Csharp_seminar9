// Задача 65: Задайте значения M и N. Напишите программу,
// которая выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintMtoN(int m, int n) // метод (рекурсия) вывода чисел от M до N
{
    if (n < m)
    {
        return;
    }
    else
    {
        PrintMtoN(m, n - 1);
        Console.Write(n + " ");
    }
}

int numberM = ReadNumber("Введите M");
int numberN = ReadNumber("Введите N");

if(numberM<=numberN)
{
    PrintMtoN(numberM, numberN);
}
else
{
    Console.WriteLine("M должно быть не больше N");
}
