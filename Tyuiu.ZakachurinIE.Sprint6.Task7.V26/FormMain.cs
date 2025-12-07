using System.Windows.Forms;
using Tyuiu.ZakachurinIE.Sprint6.Task7.V26.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task7.V26
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialogTask_ZIE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            saveFileDialogTask_ZIE.Filter = "Значения, разделённые запятыми(*.csv)|*.csv|Все файлы(*.*)|*.*";
            dataGridViewInput_ZIE.RowHeadersVisible = false;
            dataGridViewInput_ZIE.ColumnHeadersVisible = false;
            dataGridViewOutput_ZIE.RowHeadersVisible = false;
            dataGridViewOutput_ZIE.ColumnHeadersVisible = false;
            

            dataGridViewInput_ZIE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewOutput_ZIE.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
        DataService ds = new DataService();
        string path = $@"C:\DataSprint6\InPutDataFileTask7V26.csv";
        static int rows;
        static int columns;
        static string openFilePath;
        public static int[,] LoadFromFileData(string path)
        {
            string fileData= File.ReadAllText(path);
            fileData = fileData.Replace("\n", "\r");
            string[] lines = fileData.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            columns = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                string[] line_r = lines[i].Split(';');
                for (int j = 0; j < columns; j++)
                {
                    arrayValues[i,j] = Convert.ToInt32(line_r[j]);

                }
            }
            return arrayValues;
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }
        private void buttonOpen_ZIE_Click(object sender, EventArgs e)
        {
            if (openFileDialogTask_ZIE.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialogTask_ZIE.FileName;
                int[,] arrayValues = LoadFromFileData(path);
                dataGridViewInput_ZIE.ColumnCount = columns;
                dataGridViewInput_ZIE.RowCount = rows;
                for (int i = 0; i < rows; i++)
                {
                    for (int j = 0; j < columns; j++)
                    {
                        dataGridViewInput_ZIE.Rows[i].Cells[j].Value = arrayValues[i, j];
                    }
                }
                groupBoxIn_ZIE.Text = groupBoxIn_ZIE.Text + " " + openFileDialogTask_ZIE.FileName;
                buttonDone_ZIE.Enabled = true;
            }

        }
        private void buttonDone_Click(object sender, EventArgs e)
        {
            dataGridViewOutput_ZIE.RowCount = rows;
            dataGridViewOutput_ZIE.ColumnCount = columns;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = ds.GetMatrix(path);
            for (int i = 0;i < rows;i++)
            {
                for (int j = 0;j < columns;j++)
                {
                    dataGridViewOutput_ZIE.Rows[i].Cells[j].Value = arrayValues[i,j];
                }
            }
            buttonSave_ZIE.Enabled = true;

        }
        private void buttonOpenFile_Click(object sender, EventArgs e)
        {
            
            openFileDialogTask_ZIE.ShowDialog();
            path = openFileDialogTask_ZIE.FileName;
            int[,] arrayValues = new int[rows, columns];
            arrayValues = LoadFromFileData(path);
            dataGridViewInput_ZIE.ColumnCount = columns;
            dataGridViewInput_ZIE.RowCount = rows;
            dataGridViewOutput_ZIE.ColumnCount = columns;
            dataGridViewOutput_ZIE.RowCount = rows;
            for (int i = 0; i < columns; i++)
            {
                dataGridViewInput_ZIE.Columns[i].Width = 25;
                dataGridViewOutput_ZIE.Columns[i].Width = 25;
            }
            for (int i = 0;i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewInput_ZIE.Rows[i].Cells[j].Value = arrayValues[i,j];
                }
            }
            arrayValues = ds.GetMatrix(path);
            buttonDone_ZIE.Enabled = true;
        }
        private void buttonSaveFile_Click(object sender, EventArgs e)
        {
            saveFileDialogTask_ZIE.FileName = "OutPutFileTask7.csv";
            saveFileDialogTask_ZIE.InitialDirectory = $@"C:\DataSprint6";
            saveFileDialogTask_ZIE.ShowDialog();
            string path = saveFileDialogTask_ZIE.FileName;
            FileInfo fileInfo = new FileInfo(path);
            bool exists = fileInfo.Exists;
            if (exists)
            {
                File.Delete(path);
            }
            int rows = dataGridViewOutput_ZIE.RowCount;
            int columns = dataGridViewOutput_ZIE.ColumnCount;
            string str = "";
            for ( int i = 0; i < rows; i++ )
            {
                for ( int j = 0; j < columns; j++ )
                {
                    if (j!=columns-1)
                    {
                        str = str + dataGridViewOutput_ZIE.Rows[i].Cells[j].Value + ';';
                    }
                    else
                    {
                        str = str + dataGridViewOutput_ZIE.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path,str + Environment.NewLine);
                str = "";
            }
        }

    }
}
