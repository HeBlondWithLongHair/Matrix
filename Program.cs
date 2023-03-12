using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] firstArray =  { {1,2,3,4,5 },{5,4,3,2,1 },{0,9,8,7,6 },{6,7,8,9,0 } };
        double[,] secondArray =  { { 1,2,3,4,5 },{ 5,4,3,2,1 },{ 0,9,8,7,6 },{ 6,7,8,9,0 } };

        Console.WriteLine("Сложение одной матрицы с другой: ");
        Matrix.sumMatrix(firstArray, secondArray);

        Console.WriteLine("\nУмножение матрицы на число:");
        Matrix.multMatrixByNumber(firstArray, 5);

        Console.WriteLine("\nВывод матрицы: ");
        Matrix.print(firstArray);

        Console.WriteLine("\nУмножение матриц: ");
        Matrix.multMatrix(firstArray, secondArray);


    }
}

