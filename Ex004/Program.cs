/* Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)      2, 4 -> 16 */

Console.WriteLine("Задача 25. Возведение числа в степень");

Console.Write("Введите целое число, возводимое в степень: ");
int A = int.Parse(Console.ReadLine());

Console.Write("Введите степень числа: ");
int B = int.Parse(Console.ReadLine());

int index = 1;
int C = 1;

while (index <= B)

{
    C = C * A;
    index++;
}

Console.WriteLine($"Число {A} в степени {B} равно {C}");

Console.WriteLine();

/* Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11      82 -> 10      9012 -> 12 */

Console.WriteLine("Задача 27. Сумма цифр в числе");
Console.Write("Введите целое число: ");

int num = int.Parse(Console.ReadLine());
int sum = 0;

while (num > 0)
{
    sum = sum + num % 10;
    num = num / 10;   
} 

Console.WriteLine($"Сумма цифр в числе {sum}");

Console.WriteLine();

/* Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.*/

Console.WriteLine("Задача 29. Массив из 8 элементов");

void FillArray(int[] array, int A, int B)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(A, B);
    }
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int [] mass = new int[8];
FillArray (mass, 0, 20);
PrintArray (mass);









