using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Want2LearnBase
{
   public static class MatrixService
    {
        public static int[,] InputMatrixFromConsol(int rows, int cols)
        {
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = int.Parse(Console.ReadLine());
                }


            }
            return matrix;
        }

        public static void PrintMatrix(int[,] matrix, int rows, int cols)
        {
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write($"{matrix[i, j]} \t");
                }
                Console.WriteLine();
            }
        }

        static public void CountRowsAndColumns(int[,] matrix, out int rows, out int columns)
        {
            rows = matrix.GetUpperBound(0) + 1;
            columns = matrix.Length / rows;
        }

        public static bool FindByValue(int[,] matrix, int value, out int firstIndex, out int secondIndex)
        {
            firstIndex = -1;
            secondIndex = -1;
            if (matrix == null)
            {
                return false;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            bool result = false;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] == value)
                    {
                        result = true;
                        firstIndex = i;
                        secondIndex = j;
                        break;
                    }
                }
            }
            return result;

        }

        public static void Clear(int[,] matrix)
        {
            if (matrix == null)
            {
                return;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrix[i, j] = 0;

                }
            }
        }

        public static int[,] Rotate90Def(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[columns, rows];
            for (int i = 0; i < columns; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    NewMatrix[i, j] = matrix[rows - 1 - j, i];
                }
            }
            return NewMatrix;
        }

        public static bool isSquare(int[,] matrix)
        {
            if (matrix == null)
            {
                return false;
            }
            bool result = false;
            CountRowsAndColumns(matrix, out int rows, out int columns);
            if (rows == columns)
            {
                result = true;
            }
            return result;
        }

        public static int[] GetMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int size = 0;
            if (rows <= columns)
            {
                size = rows;
            }
            else
            {
                size = columns;
            }
            int[] Diagonal = new int[size];
            for (int i = 0; i < size; i++)
            {
                Diagonal[i] = matrix[i, i];
            }
            return Diagonal;
        }

        public static int[] GetSideDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int size = 0;
            if (rows <= columns)
            {
                size = rows;
            }
            else
            {
                size = columns;
            }
            int[] Diagonal = new int[size];
            for (int i = 0, j = 0; i < size; i++, j++)
            {
                Diagonal[i] = matrix[rows - 1 - i, j];
            }
            return Diagonal;
        }

        public static int SumMainDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return 0;
            }
            int sum = 0;
            int[] Diagonale = GetMainDiagonal(matrix);
            for (int i = 0; i < Diagonale.Length; i++)
            {
                sum = sum + Diagonale[i];
            }
            return sum;
        }

        public static int SumSideDiagonal(int[,] matrix)
        {
            if (matrix == null)
            {
                return 0;
            }
            int[] Diagonale = GetSideDiagonal(matrix);
            int sum = 0;
            for (int i = 0; i < Diagonale.Length; i++)
            {
                sum = sum + Diagonale[i];
            }

            return sum;

        }

        public static int[,] AddColumn(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[rows, columns + 1];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    NewMatrix[i, j] = matrix[i, j];
                }
            }

            return NewMatrix;
        }

        public static int[,] AddRow(int[,] matrix)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[rows + 1, columns];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    NewMatrix[i, j] = matrix[i, j];
                }
            }
            return NewMatrix;
        }

        public static int[,] Resize(int[,] matrix, int countRows, int countColumn)
        {
            if (matrix == null)
            {
                return null;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            int[,] NewMatrix = new int[countRows, countColumn];
            if (rows > countRows)
            {
                if (columns > countColumn)
                {
                    for (int i = 0; i < countRows; i++)
                    {
                        for (int j = 0; j < countColumn; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < countRows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
            }
            else
            {
                if (columns > countColumn)
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < countColumn; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
                else
                {
                    for (int i = 0; i < rows; i++)
                    {
                        for (int j = 0; j < columns; j++)
                        {
                            NewMatrix[i, j] = matrix[i, j];
                        }
                    }
                }
            }
            return NewMatrix;
        }

        public static void SwapRow(int[,] matrix, int rowOne, int rowTwo)
        {
            if (matrix == null)
            {
                return;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);

            for (int j = 0; j < columns; j++)
            {
                Swap(ref matrix[rowOne, j], ref matrix[rowTwo, j]);
            }
        }

        public static void SwapColumns(int[,] matrix, int columnsOne, int columnsTwo)
        {
            if (matrix == null)
            {
                return;
            }
            CountRowsAndColumns(matrix, out int rows, out int columns);
            for (int i = 0; i < rows; i++)
            {
                Swap(ref matrix[i, columnsOne], ref matrix[i, columnsTwo]);
            }
        }
    }
}
