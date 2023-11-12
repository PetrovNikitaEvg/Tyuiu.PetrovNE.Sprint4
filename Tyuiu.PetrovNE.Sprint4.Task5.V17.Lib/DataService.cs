using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.PetrovNE.Sprint4.Task5.V17.Lib
{
    public class DataService : ISprint4Task5V17
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
                    if (matrix[i, j] < 0)
                    {
                        Result++;
                    }
                }
            }
            return Result;
        }
    }
}
