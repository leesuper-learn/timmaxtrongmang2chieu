using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace timmaxtrongmang2chieu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap so hang cua ma tran: ");
            int R = int.Parse(Console.ReadLine());
            Console.Write("Nhap so cot cua ma tran: ");
            int C = int .Parse(Console.ReadLine());
            int[,] matrix = new int[R, C];
            Console.WriteLine("Ta duoc ma tran sau: ");
            // Random ra ma trận [5,5]
            Random rnd = new Random();
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    
                    matrix[row, col] = rnd.Next(1, 100);
                }
            }
            // In ra ma trận
            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                Console.WriteLine("\n");
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
            }
            //Tìm max và tọa độ của nó
            int maxValue = matrix[1, 1];
            int maxValue_row = 1;
            int maxValue_col = 1;

            for (int row = 1; row < matrix.GetLength(0); row++)
            {
                for (int col = 1; col < matrix.GetLength(1); col++)
                {
                    if (matrix[row, col] > maxValue)
                    {
                        maxValue = matrix[row, col];
                        maxValue_row = row;
                        maxValue_col = col;
                    }
                }
            }
            Console.WriteLine("\n");
            Console.WriteLine("Gia tri lon nhat la: " + maxValue);
            Console.WriteLine("Toa do la: " + (maxValue_row, maxValue_col));
            Console.ReadKey();
        }

    }
}
