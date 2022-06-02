// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

/* Console.WriteLine();

Console.WriteLine("Задача 54. Программа упорядочивания элементов массива n x m по убывания в каждой строке");

Console.Write("Введите количество строк в массиве n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве m: ");
int m = int.Parse(Console.ReadLine());

int [,] mass = new int [n,m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(1, 10);
    }
    }
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int min = 0;
int save = 0;
int MinK = 0;

for (int i = 0; i < mass.GetLength(1); i++)
{
    for (int j = 0; j < mass.GetLength(0); j++)
    {
        min = mass[j, 0];
        for (int k = 0; k < mass.GetLength(1) - i; k++)
        {
            if (mass[j, k] <= min)
            {
                min = mass[j, k];
                MinK = k;
            }
        }
        save = mass[j, mass.GetLength(1) - 1 - i];
        mass[j, mass.GetLength(1) - 1 - i] = mass[j, MinK];
        mass[j, MinK] = save;
    }
} 

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
} */


//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

/* Console.WriteLine();

Console.WriteLine("Задача 56. Программа нахождения строки с наименьшей суммой элементов массива n x m");

Console.Write("Введите количество строк в массиве n: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов в массиве m: ");
int m = int.Parse(Console.ReadLine());

int [,] mass = new int [n,m];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(1, 10);
    }
    }
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine();

int[] Sum = new int[mass.GetLength(0)];

for (int i = 0; i < mass.GetLength(0); i++)
{
    Sum[i] = 0;
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Sum[i] = Sum[i] + mass[i, j];
    }
}

int min = Sum[0];
int MinK = 0;

for (int k = 0; k < Sum.Length; k++)
{
    if (Sum[k] < min)
    {
        min = Sum[k];
        MinK = k;
    }
}

Console.WriteLine($"{MinK+1} это строка с наименьшей суммой элементов"); */



//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

/* Console.WriteLine();

Console.WriteLine("Задача 58. Программа нахождения произведения двух матриц A = (N x M) и B = (X х Y)");

Console.Write("Введите количество строк (N) в матрице A: ");
int n = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов (M) в матрице A: ");
int m = int.Parse(Console.ReadLine());

Console.Write("Введите количество строк (X) в матрице B: ");
int x = int.Parse(Console.ReadLine());

Console.Write("Введите количество столбцов (Y) в матрице B: ");
int y = int.Parse(Console.ReadLine());


int[,] mass1 = new int[n, m];

for (int i = 0; i < mass1.GetLength(0); i++)
{
    for (int j = 0; j < mass1.GetLength(1); j++)
    {
        mass1[i,j] = new Random().Next(1, 10);
    }
    } */
/* Console.WriteLine();

for (int i = 0; i < mass1.GetLength(0); i++)
{
    for (int j = 0; j < mass1.GetLength(1); j++)
    {
        Console.Write(mass1[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(); */

/* int[,] mass2 = new int[x, y];

for (int i = 0; i < mass2.GetLength(0); i++)
{
    for (int j = 0; j < mass2.GetLength(1); j++)
    {
        mass2[i,j] = new Random().Next(1, 10);
    }
}

Console.WriteLine(); */

/* for (int i = 0; i < mass2.GetLength(0); i++)
{
    for (int j = 0; j < mass2.GetLength(1); j++)
    {
        Console.Write(mass2[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(); */

/* int[,] mass3 = new int[mass1.GetLength(0),mass2.GetLength(1)];

if (mass1.GetLength(1) != mass2.GetLength(0))
{
    Console.WriteLine("Матрицы А и В не перемножаемые (количество столбцов матрицы А не равно количеству строк матрицы В");
}
else

 for (int i = 0; i < mass3.GetLength(0); i++)
    {
        for (int j = 0; j < mass3.GetLength(1); j++)
        {
            for (int k = 0; k < mass1.GetLength(1); k++)
            {
                mass3[i,j] += mass1[i, k] * mass2[k, j];
            }
        }
    }

for (int i = 0; i < mass3.GetLength(0); i++)
{
    for (int j = 0; j < mass3.GetLength(1); j++)
    {
        Console.Write(mass3[i,j] + " ");
    }
    Console.WriteLine();
} */


//Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

// сделать проверку на повторяемость элементов в трехмерном массиве не получилось. Покапался в интернете, но не смог привести программы в нужный вид.

/* int n = 3;
int m = 3;
int p = 3;


int [,,] mass = new int [n,m,p];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int z = 0; z < mass.GetLength(2); z++)
        {    
            mass[i,j,z] = new Random().Next(0, 10);
        }
    }
}
Console.WriteLine();

for (int i = 0; i < mass.GetLength(0); i++)
{   
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.WriteLine();

        for (int z = 0; z < mass.GetLength(2); z++)
        
        Console.Write($"{mass[i,j,z]} ({i},{j},{z})" + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

// Проверяем повторяемость элементов

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        for (int z = 0; z < mass.GetLength(2); z++)
        {    
            int currentElementValue = mass[i,j,z];
		
		    bool hasEquals = false; // Имеет ли текущий элемент значение, встречающееся в массиве = по умолчанию нет		
		
		    for (int a = 0; i < mass.GetLength(0); i++) //Берем элемент и ищем по массиву такое же значение
            {
                for (int b = 0; b < mass.GetLength(1); b++)
                {
                    for (int c = 1; c < mass.GetLength(2); c++)

                       {     
			            if (i == a & j == b & z == c) // С самим с собой не сравниваем, пропускаем
                        {
                            continue;
                        }
                        else
                        {    
                            if (currentElementValue == mass[a,b,c]) // Если текущий элемент равен другому элементу
                            
                                { 
                                hasEquals = true; // То устанавливаем флаг, что такое значение встречалось
                                
                                }  
                            else
                            {
                                Console.WriteLine($"{currentElementValue} ({i},{j},{z})" + " ");
                            }                    
                        
                        }
                    }
                }                  
			}                                                                       		                                       				    				
		}
	}
}
		

Console.WriteLine(); */


/* //Задача 62: Заполните спирально массив 4 на 4.

Console.WriteLine();

Console.WriteLine("Задача 62. Заполнение массива 4 на 4 последовательными числами по спирали");

int [,] mass = new int [4,4];

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        mass[i,j] = new Random().Next(1, 10);
    }
    }
Console.WriteLine();

int n = 4;
int count = 1;

for (int i = 0; i < n/2; i++)
{
    for (int j = i; j < n-i; j++)
    {
    mass[i, j] = count;
    count++;
    }
       
    for (int k=i+1; k<n-i; k++)
    {
    mass[k,n-i-1]=count;
    count++;
    }
    
    for (int j = n-i-2; j >= i; j--)
    {
    mass[n-i-1,j]=count;
    count++;
    }
    
    for (int k = n-2-i; k>i; k--)
    {
    mass[k,i]=count;
    count++;
    }
}

for (int i = 0; i < mass.GetLength(0); i++)
{
    for (int j = 0; j < mass.GetLength(1); j++)
    {
        Console.Write(mass[i,j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(); */

