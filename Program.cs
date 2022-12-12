//================ Task 1 =====================
/*

Задача 25: Напишите цикл, который принимает на
вход два числа (A и B) и возводит число A в натуральную степень B.
(Math.Pow использовать нельзя!!!)

3, 5 -> 243 (3⁵)
2, 4 -> 16

*/

void Exponentiation(int a, int b){

    int i = 0;
    int exp = 1;
    if(b<0) Console.WriteLine("a natural degree must not be less then ZERO.");
    else
    {
        while(i<b)
        {
            exp = exp * a;
            i++;    
        }
        Console.Write(exp);
    }
}

 Console.WriteLine("Enter two numbers, first will be a number, second will be а natural degree");
 Console.Write("A number: ");
 int number = Convert.ToInt32(Console.ReadLine());
 Console.Write("a natural degree: ");
 int naturalDegree = Convert.ToInt32(Console.ReadLine());
 
Exponentiation(number, naturalDegree);
