namespace AS2223_4G_INF_BunardziuVehap_RubricaCSV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            string Temp = "E:\\Progetti Visual Studio 2022\\AS2223_4G_INF_BunardziuVehap_RubricaCSV\\AS2223_4G_INF_BunardziuVehap_RubricaCSV";
            openFileDialog.FileName = Temp;
        }
    }
}