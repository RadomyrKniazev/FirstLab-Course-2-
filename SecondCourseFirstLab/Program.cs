using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondCourseFirstLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the length of arrays: ");
            int length = Convert.ToInt32(Console.ReadLine());
            int[] arrayR = new int[length];
            int[] arrayS = new int[length];
            FillingArrays(arrayR, arrayS);
            PrintArrays(arrayR, arrayS);
            int[,] matrixA = new int[arrayR.Length, arrayS.Length];

            CreateMatrixA(matrixA, arrayR, arrayS);          
            PrintMatrix(matrixA);

            matrixA = TranspozeMatrixA(matrixA);
            PrintMatrix(matrixA);
            
            matrixA = ReversedTranspozedMatrix(matrixA);
            PrintMatrix(matrixA);

            matrixA = SwapFirstRowWithLast(matrixA);
            PrintMatrix(matrixA);
            Console.WriteLine("\nEnter any key...");
            Console.ReadKey();
        }

        public static void FillingArrays(int[] arrayR, int[] arrayS)
        {
            Random random = new Random();
            for (int i = 0; i < arrayR.Length; i++)
            {
                arrayR[i] = random.Next(0, 20);
                arrayS[i] = random.Next(0, 20);
            }
        }

        public static void PrintArrays(int[] arrayR, int[] arrayS)
        {
            Console.Write("\nArray R: ");
            for (int i = 0; i < arrayR.Length; i++)
            {
                Console.Write(arrayR[i] + " ");
            }
            Console.WriteLine("\n");

            Console.Write("Array S: ");
            for (int i = 0; i < arrayS.Length; i++)
            {
                Console.Write(arrayS[i] + " ");
            }
            Console.WriteLine("\n");
        }

        public static void CreateMatrixA(int[,] matrixA, int[] arrayR, int[] arrayS)
        {
            Console.WriteLine("Matrix A");
            for (int i = 0; i < arrayR.Length; i++)
            {
                for (int j = 0; j < arrayS.Length; j++)
                {
                    matrixA[i, j] = arrayR[i] + arrayS[j];
                }
            }
        }

        public static int[,] TranspozeMatrixA(int[,] matrixA)
        {
            Console.WriteLine("Transpozed Matrix");
            int[,] transpozedMatrixA = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    transpozedMatrixA[i, j] = matrixA[j, i];
                }
            }
            return transpozedMatrixA;
        }

        public static int[,] ReversedTranspozedMatrix(int[,] matrixA)
        {
            Console.WriteLine("\nReversed transpozed matrix");
            int[,] reversedTranspozedMatrix = new int[matrixA.GetLength(0), matrixA.GetLength(1)];
            for (int i = 0; i < matrixA.GetLength(0); i++)
            {
                int z = 0;
                for (int j = matrixA.GetLength(1) - 1; j >= 0; j--, z++)
                {
                    reversedTranspozedMatrix[i, z] = matrixA[i, j];
                }
            }
            return reversedTranspozedMatrix;
        }

        public static int[,] SwapFirstRowWithLast(int[,] matrixA)
        {
            Console.WriteLine("\nSwap first line with last");
            int[] lastRow = new int[ matrixA.Length];            
            for (int i = matrixA.GetLength(0) - 1; i > matrixA.GetLength(0) - 2; i--)
            {
                for (int j = 0; j < matrixA.GetLength(1); j++)
                {
                    lastRow[j] = matrixA[i, j];
                    matrixA[i, j] = matrixA[0, j];
                    matrixA[0, j] = lastRow[j];
                }
            }
            return matrixA;
        }

        public static void PrintMatrix( int[,] matrixA)
        {                          
             for (int i = 0; i < matrixA.GetLength(0); i++)
             {
                 for (int j = 0; j < matrixA.GetLength(1); j++)
                 {
                     Console.Write("{0,4}", matrixA[i, j] + " ");
                 }
                 Console.WriteLine();
             }            
        }
    }
}
