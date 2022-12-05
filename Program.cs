//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*using System;

namespace task54
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите количество строк");
            int linesVol = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите количество столбцов");
            int columnsVol = Convert.ToInt32(Console.ReadLine());
            int[,] numbers = new int[linesVol, columnsVol];
            FillArrayRandomNumbers(numbers);
            Console.WriteLine();
            Console.WriteLine("Массив до изменения");
            PrintArray(numbers);
            
            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < numbers.GetLength(1) - 1; z++)
                    {
                        if (numbers[i, z] < numbers[i, z + 1]) //для изменения сортировки поменять знак < на противоположный
                        {
                            int temp = 0;
                            temp = numbers[i, z];
                            numbers[i, z] = numbers[i, z + 1];
                            numbers[i, z + 1] = temp;
                        }
                   }
                }
            }
            Console.WriteLine();
            Console.WriteLine("Массив с упорядоченными значениями");
            PrintArray(numbers);
            
            void FillArrayRandomNumbers(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        array[i, j] = new Random().Next(0, 10);
                    }
                }
            }

            void PrintArray(int[,] array)
            {
                for (int i = 0; i < array.GetLength(0); i++)
                {
                    Console.Write("[ ");
                    for (int j = 0; j < array.GetLength(1); j++)
                    {
                        Console.Write(array[i, j] + " ");
                    }
                    Console.Write("]");
                    Console.WriteLine("");
                }
            }
        }
    }
}
*/

//Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
int m, n; 
 int value = 1; 
 Console.Write("Введите кол-во строк "); 
 m = Int32.Parse(Console.ReadLine()); 
 Console.Write("Введите кол-во столбцов "); 
 n = Int32.Parse(Console.ReadLine()); 
 Random rnd = new Random(); 
 int[,] numbs = new int[m, n]; 
 int row = rnd.Next(numbs.GetLength(0)+1); 
 int col = rnd.Next(numbs.GetLength(1)+1); 
 for (int i = 0; i<m; i++) 
 { 
 for (int j = 0; j < n; j++) 
 { 
 numbs[i, j] = value; 
 Console.Write(numbs[i, j] + " "); 
 value++; 
 } 
 Console.WriteLine(); 
 } 

void PrintUnivariateArray(int [] tempArray)
{
    Console.WriteLine($"Суммы элементов строк массива: {string.Join(", ", tempArray)}");
}

int[] StringsValue(int [,] tempArray)
{
    int[] result = new int[tempArray.GetLength(0)];
    int stringSum = new int();

    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            stringSum += tempArray[i, j]; 
        }
        result[i] = stringSum;
        stringSum = 0;
    }

    return result;
}

void MinStringNumber(int[] tempArray)
{
    int result = new int();
    int min = tempArray.Min();
    for (int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i] == min) result = i + 1;
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
}


int[] stringsValue = StringsValue(tempArray: numbs);
PrintUnivariateArray(tempArray: stringsValue);
MinStringNumber(tempArray: stringsValue);
*/


//Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
//Например, даны 2 матрицы:
/*
(int, int, int, int) GetValues()
{
    (int, int, int, int) result = (0, 0, 0, 0);
    
    while(true)
    {
        Console.Write("Введите число строк первой матрицы: ");
        int stringsNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов первой матрицы: ");
        int columnsNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число строк второй матрицы: ");
        int stringsNumber2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов второй матрицы: ");
        int columnsNumber2 = Convert.ToInt32(Console.ReadLine());

        result = (stringsNumber1, columnsNumber1, stringsNumber2, columnsNumber2);
        if(CheckArray(a: columnsNumber1, b: stringsNumber2) == true) break; 
    }   

    return result;
}

bool CheckArray(int a, int b)
{
    if(a == b)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Произведение матриц невозможно (число столбцов первой матрицы не равно числу строк второй)\n");
        return false;
    }
}

int[,] InitArray(int arrayStrings, int arrayColumns)
{
    int [,] tempArray = new int[arrayStrings,arrayColumns];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 10);
        }
    }

    return tempArray;
}

void PrintMultivariateArray(int [,] tempArray, int number)
{
    if(number <= 2)
    Console.WriteLine($"Матрица {number}: ");
    else
    Console.WriteLine($"Результирующая матрица: ");
    
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

int MatrixCount(int number)
{
    int result = new int();
    result = number + 1;
    return result;
}

int [,] MatrixMultiplication(int [,] tempArray1, int [,] tempArray2)
{
    int [,] result = new int[tempArray1.GetLength(0),tempArray2.GetLength(1)];
    for (int i = 0; i < tempArray1.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray2.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray1.GetLength(1); k++)
            {
                result[i, j] += tempArray1[i,k] * tempArray2[k,j];
            }
        }
    }

    return result;
}

(int, int, int, int) arrayParameters = GetValues();
Console.WriteLine();
int matrixNumber = 0;
int[,] matrix1 = InitArray(arrayStrings: arrayParameters.Item1, arrayColumns: arrayParameters.Item2);
matrixNumber = MatrixCount(number: matrixNumber);
PrintMultivariateArray(tempArray: matrix1, number: matrixNumber);
Console.WriteLine();
int[,] matrix2 = InitArray(arrayStrings: arrayParameters.Item3, arrayColumns: arrayParameters.Item4);
matrixNumber = MatrixCount(number: matrixNumber);
PrintMultivariateArray(tempArray: matrix2, number: matrixNumber);
Console.WriteLine();
int[,] matrix3 = MatrixMultiplication(tempArray1: matrix1, tempArray2: matrix2);
matrixNumber = MatrixCount(number: matrixNumber);
PrintMultivariateArray(tempArray: matrix3, number: matrixNumber);
*/

//Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.WriteLine("Введите значение по x : ");
int x = int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение по y : ");
int y= int.Parse(Console.ReadLine());
Console.WriteLine("Введите значение по z : ");
int z = int.Parse(Console.ReadLine());

int[,,] array3D = new int[x, y, z];
CreateArray(array3D);
PrintNumber(array3D);
void CreateArray(int[,,] array3D)
{
  int[] temp = new int[array3D.GetLength(0) * array3D.GetLength(1) * array3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 20);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 20);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < array3D.GetLength(0); x++)
  {
    for (int y = 0; y < array3D.GetLength(1); y++)
    {
      for (int z = 0; z < array3D.GetLength(2); z++)
      {
        array3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
void PrintNumber(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i,j,k]} ({i},{j},{k})");
            }
        }
        Console.WriteLine();
    }

}
*/