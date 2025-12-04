using Tyuiu.ZakachurinIE.Sprint6.Task3.V17.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task3.V17
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        int[,] matrix = new int[5, 5] { { 22, 32, -16, 24, 27 }, { 3, -20, 24, -20, 25 }, { 21, 17, -8, -19, 17 }, { 8,22,28,27,19}, {11,20,12,27,29 } };
        private void buttonHelp_CLick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Закачурин Иван Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0)+1;
            int columns = matrix.Length/rows;

            dataGridViewResult_ZIE.ColumnCount = columns;
            dataGridViewResult_ZIE.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewResult_ZIE.Columns[i].Width = 25;
            }
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0;j < columns; j++)
                {
                    dataGridViewResult_ZIE.Rows[i].Cells[j].Value = Convert.ToString(matrix[i,j]);
                }
            }
        }
        private void buttoneDone_Click(object sender, EventArgs e)
        {
            
            int[,] matrix = new int[,]
            {        { 22, 32, -16, 24, 27 },        { 3, -20, 24, -20, 25 },        { 21, 17, -8, -19, 17 },        { 8, 22, 28, 27, 19 },       { 11, 20, 12, 27, 29 }    };

            
            int[,] sortedMatrix = ds.Calculate(matrix);

            // 3. Настройка DataGridView
            dataGridViewResult_ZIE.RowCount = 5;
            dataGridViewResult_ZIE.ColumnCount = 5;

            
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    dataGridViewResult_ZIE.Rows[i].Cells[j].Value = sortedMatrix[i, j];
                }
            }
        }

    }
}
