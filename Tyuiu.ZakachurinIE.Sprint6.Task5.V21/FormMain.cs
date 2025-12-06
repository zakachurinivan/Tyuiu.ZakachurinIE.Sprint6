using Tyuiu.ZakachurinIE.Sprint6.Task5.V21.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task5.V21
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"C:\DataSprint6\InPutDataFileTask5V21.txt";
        private void buttoneDone_Click(object sender, EventArgs e)
        {
            dataGridViewResult_ZIE.ColumnCount = 2;
            dataGridViewResult_ZIE.Columns[0].Width = 20;
            dataGridViewResult_ZIE.Columns[1].Width = 40;
            this.chartFunction_ZIE.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_ZIE.ChartAreas[0].AxisY.Title = "Ось Y";
            chartFunction_ZIE.Series[0].Points.Clear();
            double[] numsMass = new double[ds.len];
            numsMass = ds.LoadFromDataFile(path);
            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_ZIE.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_ZIE.Series[0].Points.AddXY(i,numsMass[i]);
            }
        }
        private void buttonOpen_CLick(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
        private void buttonHelp_CLick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 4 выполнил студент группы ИБКСб-25-1 Закачурин Иван Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
