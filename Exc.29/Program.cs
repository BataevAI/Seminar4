//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран. Данные вводятся с консоли пользователем

// создаем метод внесения size элементов в массив

int[] ArrayRead(int size) 
{

int[] array = new int[size]; 

    for (int j = 0; j < size; j++)
        {
            
            
            if (j == size - 1) 
            
                {
                Console.WriteLine($"... и последнее число :)");
                }

                else 
                    {
                    Console.WriteLine($"Внесите число № {j + 1}");
                    }

             array[j] = Convert.ToInt32(Console.ReadLine());   

        }


return array;

}

// просим внести размер массива

Console.WriteLine("Введите размер массива чисел, который мы будем выводить на экран");
int size1 = Math.Abs(Convert.ToInt32(Console.ReadLine()));

// просим внести сами числа массива

Console.WriteLine($"Введите {size1} чисел массива ");

// вызываем наш метод и проводим магию

int[] totalArr = ArrayRead(size1);
string str = string.Join(", ", totalArr);

Console.WriteLine("Итоговый массив: " + str );
