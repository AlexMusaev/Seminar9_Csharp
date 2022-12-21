// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

void NumberInversion(int num)
{
    System.Console.Write(num + " ");
    if(num > 1)
        NumberInversion(num - 1);
}


int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int number = AddNumber("Введите число");
NumberInversion(number);

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNumbersInBetween(int numA, int numB)
{
    if(numA == numB)
        return numB;
    return SumNumbersInBetween(numA + 1, numB) + numA;
}

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}


int numberM = AddNumber("Введите первое число");
int numberN = AddNumber("Введите второе число");
if(numberM < numberN)
{
    int sum = SumNumbersInBetween(numberM, numberN);
    System.Console.WriteLine(sum);
}
else
    System.Console.WriteLine("Некоректный ввод");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29


int AckermanFunction(int m, int n)
{
    if(m == 0)
        return n + 1;
    if( m > 0 && n == 0)
        return AckermanFunction(m - 1, 1);
    else
        return AckermanFunction(m - 1, AckermanFunction(m, n -1));
}

int AddNumber(string meseg)
{
    System.Console.WriteLine(meseg);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int numberM = AddNumber("Введите число m");
int numberN = AddNumber("Введите число n");
int Ackerman = AckermanFunction(numberM, numberN);
System.Console.WriteLine(Ackerman);