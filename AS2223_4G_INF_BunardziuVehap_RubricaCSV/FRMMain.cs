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
            OpenFileDialog FinestraFile = new OpenFileDialog(); //inizializza una nuova variabile FinestraFile di tipo OpenFileDialog (OpenFileDialog visualizza una finestra che chiede di aprire un file)
            if (FinestraFile.ShowDialog() == DialogResult.OK)
            {
                TXT_File.Text = FinestraFile.FileName; //.FileName ottiene l'indirizzo del file selezionato sulla finestra
            }

            
        }

        private void BTN_Visualizza_Click(object sender, EventArgs e)
        {
            string Cognome = TXT_Cognome.Text; //Legge cosa ho scritto sulla seconda textbox
            string SceltaCombobox = CBX_Scelta.Text; //legge cosa ho scelto nella combobox 

        }
    }
} 