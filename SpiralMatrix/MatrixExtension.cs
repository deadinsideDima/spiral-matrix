using System;

namespace SpiralMatrix
{
    /// <summary>
    /// Matrix manipulation.
    /// </summary>
    public static class MatrixExtension
    {
        /// <summary>
        /// Fills the matrix with natural numbers, starting from 1 in the top-left corner, increasing in an inward, clockwise spiral order.
        /// </summary>
        /// <param name="size">Matrix size.</param>
        /// <returns>Filled matrix.</returns>
        /// <exception cref="ArgumentException">Thrown when matrix size less or equal zero.</exception>
        /// <example> size = 3
        ///     1 2 3
        ///     8 9 4
        ///     7 6 5.
        /// </example>
        /// <example> size = 4
        ///     1  2  3  4
        ///     12 13 14 5
        ///     11 16 15 6
        ///     10 9  8  7.
        /// </example>
        public static int[,] GetMatrix(int size)
        {
            if (size < 1)
            {
                throw new ArgumentException("Matrix size cannot be less or equal zero");
            }

            int[,] matrix = new int[size, size];
            int x = 0, y = 0, max = size - 1, min = 0;
            for (int i = 1; i <= size * size; i++)
            {
                matrix[x, y] = i;
                if (x == min && y != max)
                {
                    y++;
                }
                else
                {
                    if (y == max && x != max)
                    {
                        x++;
                    }
                    else
                    {
                        if (x == max && y != min)
                        {
                            y--;
                        }
                        else
                        {
                            if (y == min && x != min + 1)
                            {
                                x--;
                            }
                            else
                            {
                                max -= 1;
                                min += 1;
                                y++;
                            }
                        }
                    }
                }
            }

            return matrix;
        }
    }
}
