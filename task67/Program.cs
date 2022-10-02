// Задача 67: Напишите программу, которая будет принимать
// на вход число и возвращать сумму его цифр.
// 453 -> 12
// 45 -> 9

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int SumDigital(int number) // метод (рекурсия) суммирования цифр числа
{
    if (number == 0)
    {
        return 0;
    }
    else
    {
        return number % 10 + SumDigital(number / 10);
    }
}

int number = ReadNumber("Введите число");
int sum = SumDigital(number);
Console.WriteLine(sum);

