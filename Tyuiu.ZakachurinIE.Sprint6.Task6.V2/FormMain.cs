using Tyuiu.ZakachurinIE.Sprint6.Task6.V2.Lib;

namespace Tyuiu.ZakachurinIE.Sprint6.Task6.V2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        string path = $@"C:\DataSprint6\InPutDataFileTask6V2.txt";
        private void buttonDone_Click(object sender, EventArgs e)
        {

            textBoxOutPut_ZIE.Text = ds.CollectTextFromFile(path);
        }
        

        private void buttonOpen_ZIE_Click(object sender, EventArgs e)
        {
            if (openFileDialogTak_ZIE.ShowDialog() == DialogResult.OK)
            {
                path = openFileDialogTak_ZIE.FileName;
                textBoxInput_ZIE.Text = File.ReadAllText(path);
                groupBoxIn_ZIE.Text = groupBoxIn_ZIE.Text + " " + openFileDialogTak_ZIE.FileName;
                buttonDone_ZIE.Enabled = true;
            }

        }

        private void buttonHelp_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }



    }
}
