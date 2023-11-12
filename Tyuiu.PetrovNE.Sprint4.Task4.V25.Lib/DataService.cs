using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PetrovNE.Sprint4.Task4.V25.Lib
{
    public class DataService : ISprint4Task4V25
    {
        public int Calculate(int[,] matrix)
        {
            int Result = 0;
            int rows = matrix.GetUpperBound(0) + 1; //строки
            int columns = matrix.Length / rows; // столбцы

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        Result += matrix[i, j];
                    }
                }
            }
            return Result;
        }
    }
}
