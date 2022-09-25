namespace AS2223_4G_INF_BunardziuVehap_RubricaCSV
{
    public partial class Form1 : Form
    {
        public string[] Nome = new string[1000];
        public string[] Cognome = new string[1000];
        public string[] Citta = new string[1000];
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
            StreamReader Fi = new StreamReader(FinestraFile.FileName); //leggo il file .CSV
            int nRighe = File.ReadLines(FinestraFile.FileName).Count(); //leggo e conto quante righe ha il file .CSV
            for (int i = 0; i < nRighe; i = i+3)
            {
                string[] temparr = new string[3]; //creo un array temporaneo in cui mi salvo il valore restituito da split
                string temp = Fi.ReadLine(); //ho salvato i valori del file .CSV dentro la variabile temporanea. 
                temparr = temp.Split(','); //utilizzato il .Split() per separare le varie parole all'interno di temp (il valore di temp è Nome,Cognome,Citta). Il valore restituito però è un array quindi lo salvo dentro al mio array di stringhe temporaneo
                //salvo i valori dentro i miei array
                Nome[i] = temparr[0]; 
                Cognome[i] =temparr[1];
                Citta[i] = temparr[2];
            }
        }

        private void BTN_Visualizza_Click(object sender, EventArgs e)
        {
            string Cognome = TXT_Cognome.Text; //Legge cosa ho scritto sulla seconda textbox
            string SceltaCombobox = CBX_Scelta.Text; //legge cosa ho scelto nella combobox 
            
        }
    }
} 