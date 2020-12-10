using System;

namespace Matrix_____x__
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix1 = new int[2 , 2];
            int[,] matrix2 = new int[2, 2];
            while (true)
            {
                //Matrix 1
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("Enter Matrix 1 [{0}{1}] :", i, j);
                        matrix1[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                //Matrix 2
                Console.ForegroundColor = ConsoleColor.Red;
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 2; j++)
                    {
                        Console.Write("Enter Matrix 2 [{0}{1}] :", i, j);
                        matrix2[i, j] = int.Parse(Console.ReadLine());
                    }
                }
                Console.ForegroundColor = ConsoleColor.White;
                Total(matrix1, matrix2);
                Submission(matrix1, matrix2);
                Multiplication(matrix1, matrix2);
                Division(matrix1, matrix2);
                Transpose(matrix1 , "Matrix1");
                Transpose(matrix2, "Matrix2");
                #region voids
                //Total
                static int[,] Total(int[,] _matrix1 , int[,] _matrix2)
                {
                    int[,] totalMatrixs = new int[2, 2];
                    Console.WriteLine("Total Submission: ");
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            totalMatrixs[i, j] = _matrix1[i, j] + _matrix2[i, j];
                            Console.Write("[{0}]", totalMatrixs[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return totalMatrixs;
                }
                //Submission
                static int[,] Submission(int[,] _matrix1, int[,] _matrix2)
                {
                    Console.WriteLine("Submission Submission: ");
                    int[,] submissionMatrixs = new int[2, 2];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            submissionMatrixs[i, j] = _matrix1[i, j] - _matrix2[i, j];
                            Console.Write("[{0}]", submissionMatrixs[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return submissionMatrixs;
                }
                //Multiplication
                static int[,] Multiplication(int[,] _matrix1, int[,] _matrix2)
                {
                    Console.WriteLine("Multiplication Submission: ");
                    int[,] multiplicationMatrixs = new int[2, 2];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            multiplicationMatrixs[i, j] += _matrix1[i, j] * _matrix2[i, j];
                            Console.Write("[{0}]", multiplicationMatrixs[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return multiplicationMatrixs;
                }
                //Division
                static int[,] Division(int[,] _matrix1, int[,] _matrix2)
                {
                    Console.WriteLine("Division Submission: ");
                    int[,] divisionMatrixs = new int[2, 2];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            divisionMatrixs[i, j] += _matrix1[i, j] / _matrix2[i, j];
                            Console.Write("[{0}]", divisionMatrixs[i, j]);
                        }
                        Console.WriteLine();
                    }
                    return divisionMatrixs;
                }
                //Transpose
                static int[,] Transpose(int[,] _matrix , string name)
                {
                    Console.WriteLine("Transpose Submission {0}: " , name);
                    int[,] transposeMatrixs = new int[2, 2];
                    for (int i = 0; i < 2; i++)
                    {
                        for (int j = 0; j < 2; j++)
                        {
                            transposeMatrixs[j, i] = _matrix[i, j];
                            Console.Write("[{0}]", transposeMatrixs[i , j]);
                        }
                        Console.WriteLine();
                    }
                    return transposeMatrixs;
                }
                #endregion

                Console.ReadKey();
            }
        }
    }
}
