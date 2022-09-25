namespace AS2223_4G_INF_BunardziuVehap_RubricaCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog FinestraFile = new OpenFileDialog();
            if (FinestraFile.ShowDialog() == DialogResult.OK)
            {
                TXT_File.Text = FinestraFile.FileName;
            }
        }
    }
}