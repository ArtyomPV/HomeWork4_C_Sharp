//================ Task 1 =====================
/*

Задача 25: Напишите цикл, который принимает на
вход два числа (A и B) и возводит число A в натуральную степень B.
(Math.Pow использовать нельзя!!!)

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

// void Exponentiation(int a, int b){

//     int i = 0;
//     int exp = 1;
//     if(b<0) Console.WriteLine("a natural degree must not be less then ZERO.");
//     else
//     {
//         while(i<b)
//         {
//             exp = exp * a;
//             i++;    
//         }
//         Console.Write(exp);
//     }
// }

//  Console.WriteLine("Enter two numbers, first will be a number, second will be а natural degree");
//  Console.Write("A number: ");
//  int number = Convert.ToInt32(Console.ReadLine());
//  Console.Write("a natural degree: ");
//  int naturalDegree = Convert.ToInt32(Console.ReadLine());

// Exponentiation(number, naturalDegree);

//==================== Task 2 =========================
/*
Задача 27: Напишите программу, которая принимает на вход число
 и выдаёт сумму цифр в числе.(Массивы и строки использовать нельзя!!!)

452 -> 11

82 -> 10

9012 -> 12
*/
/*
Получаем многозначное число
создаем метод, метод содердит переменную которая аккумулирует значение
создаем цикл, в котором определяем остаток от 10, данный остаток складываем в переменную аккумулятор
далее уменьшаем предоставленное число на 10 и проводим определение остатка заново, 
пока переменная после уменьшения на 10 не станет равным нулю

*/
// int Sum(int num)
// {
//         int sum = 0;
//         while(num>0)
//         {
//             sum += num%10;
//             num = num/10;
//         }
//         return sum;
// }

// Console.Write("Enter any number from 0 to 2 147 483 647: ");
// int number = Convert.ToInt32(Console.ReadLine());
// int summa = Sum(number);
// Console.WriteLine(summa);

//========================  Task 3 ===================
/*
Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/

/*
Запрашиваем у пользователя  элементов массива
далее создаем метод, в методе перебором каждого элемента массива заполняем массив
значениями который также предоставит пользователь
*/

int[] FillArray(int length)
{
    int[] arr = new int[length];
    for (int i = 0; i < length; i++)
    {
        Console.Write($"Enter {i} element of array: ");
        arr[i] = Convert.ToInt32(Console.ReadLine());
    }
    return arr;
}

void ShowArray( int[] array)
{
    Console.Write("Entered array: [");
    for (int i = 0; i < array.Length; i++)
    {
        if(i<array.Length-1)
        {
            Console.Write($"{array[i]}, ");
        }
        else 
        {
            Console.Write($"{array[i]}");
        }
    }
    Console.Write("]");
}

Console.Write("Enter quality of array`s element: ");
int arrayLength = Convert.ToInt32(Console.ReadLine());

ShowArray(FillArray(arrayLength));
