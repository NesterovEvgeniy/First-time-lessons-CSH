/* Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да */

Console.WriteLine("Задача 19. Определение является ли число полиндромом");

Console.Write("Введите целое пятизначное число: ");

int num = int.Parse(Console.ReadLine());

if (num / 10000 == num % 10 & num / 1000 % 10 == num / 10 % 10 % 10 % 10)
{
    Console.WriteLine("Число является полиндромом");
}
else
{   
    Console.WriteLine("Число не является полиномом");
}


/* Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53 */

Console.WriteLine("Задача 21. Определение расстояния между 3-мя точками в 3D пространстве");

Console.WriteLine("Введите координа ты первого числа (три нутуральных числа): ");

int X1 = int.Parse(Console.ReadLine());
int Y1 = int.Parse(Console.ReadLine());
int Z1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координа ты второго числа (три нутуральных числа): ");

int X2 = int.Parse(Console.ReadLine());
int Y2 = int.Parse(Console.ReadLine());
int Z2 = int.Parse(Console.ReadLine());

double length = Math.Sqrt(Math.Pow(X2-X1,2) + Math.Pow(Y2-Y1,2) + Math.Pow(Z2-Z1,2));

Console.WriteLine($"Расстояние между 3-мя точками в 3D пространстве {length}");


/* Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125 */

Console.WriteLine("Задача 23. Таблица кубов до числа N");
Console.WriteLine("Введите положительное натуральное число: ");

int N = int.Parse(Console.ReadLine());
int index = 1;
while (index <= N)
{
    Console.WriteLine(Math.Pow(index, 3));
    index++;
}




