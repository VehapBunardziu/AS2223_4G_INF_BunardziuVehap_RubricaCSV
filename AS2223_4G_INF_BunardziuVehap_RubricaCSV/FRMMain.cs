namespace AS2223_4G_INF_BunardziuVehap_RubricaCSV
{
    public partial class Form1 : Form
    {
        static string[] Nome = new string[1000];
        static string[] Cognome = new string[1000];
        static string[] Citta = new string[1000];
        static int nRighe;
        static bool Scelto = false;
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
                Scelto = true;
            }
            else
            {
                MessageBox.Show("Non hai selezionato un File. Selezionarne uno per continuare.", "ERRORE");
                return;
            }
            StreamReader Fi = new StreamReader(FinestraFile.FileName); //leggo il file .CSV
            nRighe = File.ReadLines(FinestraFile.FileName).Count(); //leggo e conto quante righe ha il file .CSV
            for (int i = 0; i < nRighe; i++)
            {
                string[] temparr = new string[3]; //creo un array temporaneo in cui mi salvo il valore restituito da split
                string temp = Fi.ReadLine(); //ho salvato i valori del file .CSV dentro la variabile temporanea. 
                temparr = temp.Split(';'); //utilizzato il .Split() per separare le varie parole all'interno di temp (il valore di temp è Nome,Cognome,Citta). Il valore restituito però è un array quindi lo salvo dentro al mio array di stringhe temporaneo
                //salvo i valori dentro i miei array
                Nome[i] = temparr[0]; 
                Cognome[i] =temparr[1];
                Citta[i] = temparr[2];
            }
        }

        private void BTN_Visualizza_Click(object sender, EventArgs e)
        {
            if(Scelto)
            {
               
                string SceltaCombobox = CBX_Scelta.Text; //legge cosa ho scelto nella combobox 
                if (SceltaCombobox == "")
                {
                    MessageBox.Show("Non hai scelto niente.", "ERRORE");
                    return;
                }
                string Parola = TXT_Cognome.Text; //Legge cosa ho scritto sulla seconda textbox
                if(Parola == "")
                {
                    MessageBox.Show("Non hai inserito nessuna parola.", "ERRORE");
                    return;
                }

                if (SceltaCombobox == "Inizia")
                {
                    LST_Elenco.Items.Clear();
                    for (int i = 0; i < nRighe; i++)
                    {
                        if (Cognome[i].ToUpper().StartsWith(Parola.ToUpper()))
                        {
                            LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]);
                        }
                    }
                }
                else if (SceltaCombobox == "Contiene")
                {
                    LST_Elenco.Items.Clear();
                    for (int i = 0; i < nRighe; i++)
                    {
                        if (Cognome[i].ToUpper().Contains(Parola.ToUpper()))
                        {
                            LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]);
                        }
                    }
                }
                else if (SceltaCombobox == "Finisce")
                {
                    LST_Elenco.Items.Clear();
                    for (int i = 0; i < nRighe; i++)
                    {
                        if (Cognome[i].ToUpper().EndsWith(Parola.ToUpper()))
                        {
                            LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]);
                        }
                    }
                }
                else if (SceltaCombobox == "Stampa Tutto")
                {
                    LST_Elenco.Items.Clear();
                    for (int i = 0; i < nRighe; i++)
                    {
                        LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]);
                    }
                }
            }
            else
            {
                MessageBox.Show("Non hai inserito un file.", "ERRORE");
            }
                
        }
    }
} 