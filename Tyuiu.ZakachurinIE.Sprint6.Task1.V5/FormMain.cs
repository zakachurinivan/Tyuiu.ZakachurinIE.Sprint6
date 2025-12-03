using Tyuiu.ZakachurinIE.Sprint6.Task1.V5.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task1.V5
{
    public partial class FormMain_ZIE : Form
    {
        public FormMain_ZIE()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_CLick(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxInputSRT_ZIE.Text);
                int stopStep = Convert.ToInt32(textBoxInputSTP_ZIE.Text);
                string strLine;
                int len = ds.GetMassFunction(startStep, stopStep).Length;
                double[] valueArray;
                valueArray = new double[len];
                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_ZIE.Text = "";
                textBoxResult_ZIE.AppendText("+--------+--------+" + Environment.NewLine);
                textBoxResult_ZIE.AppendText("|      X       |   f(x)   |" + Environment.NewLine);
                textBoxResult_ZIE.AppendText("+--------+--------+" + Environment.NewLine);
                for (int i = 0; i < len; i++)
                {
                    strLine = String.Format("|    {0,5:d}    |     {1,5:f2}     |", startStep, valueArray[i]);
                    textBoxResult_ZIE.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }
                textBoxResult_ZIE.AppendText("+--------+--------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Введены неверные данные","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void buttonHelp_CLick(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы ИБКСб-25-1 Закачурин Иван Евгеньевич", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
