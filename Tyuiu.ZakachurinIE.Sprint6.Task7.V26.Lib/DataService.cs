using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.ZakachurinIE.Sprint6.Task7.V26.Lib
{
    public class DataService : ISprint6Task7V26
    {
        public int[,] GetMatrix(string path)
        {
            string[] lines = File.ReadAllLines(path);

            
            int rows = lines.Length;
            string[] firstLineValues = lines[0].Split(';'); 
            int cols = firstLineValues.Length;

            
            int[,] matrix = new int[rows, cols];

            
            for (int i = 0; i < rows; i++)
            {
                string[] values = lines[i].Split(';');
                for (int j = 0; j < cols; j++)
                {
                    int.TryParse(values[j], out matrix[i, j]);
                }
            }

            
            int targetColumn = 1;

            for (int r = 0; r < rows; r++)
            {
                if (matrix[r, targetColumn] > 5)
                {
                    matrix[r, targetColumn] = 222;
                }
            }

            return matrix;
        }
    }
}
