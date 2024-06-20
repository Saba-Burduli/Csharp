using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace saklaso_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] number =
{
  {1,2,3,4},
  {5,6,7,8},
  {9,10,11,12}
};

            int col = number.GetLength(0);
            int row = number.GetLength(1);

            Console.WriteLine($" row : {row}  ; column : {col}");

            for (int i = 0; i < number.GetLength(1); i++)
            {
                for (int j = 0; j < number.GetLength(0); j++)
                {
                    Console.Write(number[j, i] + " "  );
                }

                Console.WriteLine();    
            }






            int[,] arrsaba =
            {
                {1, 2, 3, 4},
                {5, 6, 7, 8},
                {9, 10, 11, 12}
            };

            int rows = arrsaba.GetLength(0); 
            int cols = arrsaba.GetLength(1); 

         
            int[,] comicsolvency = new int[cols, rows];

            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    comicsolvency[j, i] = arrsaba[i, j];
                }
            }

          
            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(comicsolvency[i, j] + " ");
                }
                Console.WriteLine();
            }




        }
    }
}
