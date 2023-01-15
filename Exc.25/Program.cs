// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
// Не использовать Math.Pow() и аналоги!



// создаем метод возведения в степень 

 int degree (int numA, int numB) {
    
    int numC = 1;
    for (int i = 1; i <= numB; i++) {
    
    numC = numC * numA; }
    
    return numC;
    
    }

// просим внести искомые два числа А и В



int degreeAB;


Console.WriteLine("Введите два числа : А (целое число) и В (натуральное число), а мы возведем А в степень числа В");

int numberA = Convert.ToInt32(Console.ReadLine());
int numberB = 0; 

while(numberB < 1) {

numberB = Convert.ToInt32(Console.ReadLine());

if ( numberB < 1) {Console.WriteLine("необходимо ввести число > 1, внесите еще раз В"); 
    
}

}


degreeAB = degree(numberA, numberB);

Console.WriteLine($" число {numberA} в степени {numberB} равно {degreeAB}");

