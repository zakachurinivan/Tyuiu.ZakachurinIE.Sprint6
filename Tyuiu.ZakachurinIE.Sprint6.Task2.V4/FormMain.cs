using Tyuiu.ZakachurinIE.Sprint6.Task2.V4.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task2.V4
{
    public partial class FormMainTask_ZIE : Form
    {
        public FormMainTask_ZIE()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonDone_ZIE_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputStart_ZIE.Text);
                int stopStep = Convert.ToInt32(textBoxInputStop_ZIE.Text);
                
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartResult_ZIE.Titles.Add("График функции");
                this.chartResult_ZIE.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartResult_ZIE.ChartAreas[0].AxisY.Title = "Ось Y";
                for (int i = 0; i < len; i++)
                {
                    this.dataGridViewFunction_ZIE.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartResult_ZIE.Series[0].Points.AddXY(startStep, stopStep);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void buttonHelp_CLick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ИБКСб-25-1 Закачурин Иван Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
