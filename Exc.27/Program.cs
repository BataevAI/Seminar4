// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// создаем метод подсчета цифр в произвольном числе

int SumOfDigits(int number) 
{

int sumDigits = 0;

    while(number %10 != 0 || number/10 != 0)

    {
        sumDigits = sumDigits + Math.Abs(number)%10;

          number = number/10;  
    }


    return sumDigits;
}

Console.WriteLine("Введите целое число");

int N = Convert.ToInt32(Console.ReadLine());

// вызываем метод сложения цифр нашего числа

int summa = SumOfDigits(N);
Console.WriteLine($"Сумма цифр нашего числа составит: {summa}");


