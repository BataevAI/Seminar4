// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!


int numberA = 0;
int numberB = 0; 
int numC = 1;
int degreeAB;

// создаем метод возведения в степень 

 int degree (int numA, int numB) {
    for (int i = 1; i <= numB; i++) {
    
    numC = numC * numA; }
    
    return numC;
    
    }

// просим внести искомые два числа А и В

Console.WriteLine("Введите два числа : А (целое число) и В (натуральное число), а мы возведем А в степень числа В");

numberA = Convert.ToInt32(Console.ReadLine());

while(numberB < 1) {

numberB = Convert.ToInt32(Console.ReadLine());

if ( numberB < 1) {Console.WriteLine("необходимо ввести число > 1, внесите еще раз В"); 
    
}

}

   

degreeAB = degree(numberA, numberB);

Console.WriteLine($" число {numberA} в степени {numberB} равно {degreeAB}");

