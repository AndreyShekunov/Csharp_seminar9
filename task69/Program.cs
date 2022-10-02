// Задача 69: Напишите программу, которая на вход принимает два числа A и B,
// и возводит число А в целую степень B с помощью рекурсии.
// A = 3; B = 5 -> 243 (3⁵)
// A = 2; B = 3 -> 8

int ReadNumber(string message) // метод ввода числа
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int PowAtoB(int A, int B) // метод (рекурсия) возведения числа А в степень В
{
    if (B == 0)
    {
        return 1;
    }
    else
    {
        return A * PowAtoB(A, B-1); 
    }
}

int numberA = ReadNumber("Введите число A");
int numberB = ReadNumber("Введите число B");
int result = PowAtoB(numberA, numberB);
Console.WriteLine(result);