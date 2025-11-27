using Tyuiu.ZakachurinIE.Sprint6.Task0.V17.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task0.V17
{
    public partial class Formmain : Form
    {
        public Formmain()
        {
            InitializeComponent();
        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            
        }

        private void buttonDone_ZIE_Click(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxResult_ZIE.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxVarA_ZIE.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные","Ошибка",MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarA_ZIE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != ',') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_ZIE_Click(Object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент группы ИБКСБ-25-1 Закачурин Иван Евгеньевич");
        }
    }
}
