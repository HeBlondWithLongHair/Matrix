using System;

public class Matrix
{

    public static void sumMatrix(double[,] firstArray, double[,] secondArray)
    {
        double[,] sumArray = new double[firstArray.GetLength(0), firstArray.GetLength(1)];

        if (firstArray.GetLength(0) == secondArray.GetLength(0))
        {
            if (firstArray.GetLength(1) == secondArray.GetLength(1))
            {
                for (int i = 0; i < firstArray.GetLength(0); i++)
                {
                    for (int j = 0; j < firstArray.GetLength(1); j++)
                    {
                        sumArray[i, j] = firstArray[i, j] + secondArray[i, j];
                        Console.Write(sumArray[i, j] + " ");
                    }
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("Столбцы матриц должны быть одного размера");
            }
        }
        else
        {
            Console.WriteLine("Строки матриц должны быть одного размера!");
            return;
        }
        
        
    }

    public static void multMatrixByNumber(double[,] firstArray, double number)
    {
        

        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < firstArray.GetLength(0); j++)
            {
                firstArray[i, j] = firstArray[i, j] * number;
                Console.Write(firstArray[i,j] + " ");
            }

            Console.WriteLine();
        }
        
    }

    public static void print(double[,] firstArray)
    {
        for (int i = 0; i < firstArray.GetLength(0); i++)
        {
            for (int j = 0; j < firstArray.GetLength(1); j++)
            {
                Console.Write(firstArray[i,j] + " ");
            }

            Console.WriteLine();
        }
    }

    public static void multMatrix(double[,] firstArray, double[,] secondArray)
    {
        double[,] Array = new double[firstArray.GetLength(0), firstArray.GetLength(1)];

        if (firstArray.GetLength(0) == secondArray.GetLength(0))
        {
            if (firstArray.GetLength(1) == secondArray.GetLength(1))
            {
                for (int i = 0; i < firstArray.GetLength(0); i++)
                {
                    for (int j = 0; j < firstArray.GetLength(1); j++)
                    {
                        Array[i, j] = firstArray[i, j] * secondArray[i, j];
                        Console.Write(Array[i, j] + " ");
                    }
                    Console.WriteLine();

                }
            }
            else
            {
                Console.WriteLine("Столбцы матриц должны быть одного размера");
            }
        }
        else
        {
            Console.WriteLine("Строки матриц должны быть одного размера!");
            return;
        }

    }



}
