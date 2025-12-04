using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakachurinIE.Sprint6.Task3.V17.Lib
{
    public class DataService : ISprint6Task3V17
    {
        public int[,] Calculate(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = (int[,])matrix.Clone();

            int columnToSort = 3;
            if (columnToSort < cols)
            {
                
                int[] columnValues = new int[rows];
                for (int i = 0; i < rows; i++)
                {
                    columnValues[i] = matrix[i, columnToSort];
                }

                
                Array.Sort(columnValues);

                
                for (int i = 0; i < rows; i++)
                {
                    result[i, columnToSort] = columnValues[i];
                }
            }
            return result;
        }
    }
}
