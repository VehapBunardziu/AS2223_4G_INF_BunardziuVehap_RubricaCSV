namespace AS2223_4G_INF_BunardziuVehap_RubricaCSV
{
    public partial class frmMain : Form
    {
        //variabili globali che mi salvano i nomi, cognomi e citta
        static string[] Nome = new string[1000]; 
        static string[] Cognome = new string[1000];
        static string[] Citta = new string[1000];
        //variabile che mi salva il numero delle righe presenti nel file .CSV
        static int nRighe;
        //variabile di stato che mi dice se abbiamo scelto un file sì o no. 
        static bool Scelto = false;
        public frmMain()
        {
            InitializeComponent();
        }

        private void BTN_File_Click(object sender, EventArgs e)
        {
            OpenFileDialog FinestraFile = new OpenFileDialog(); //inizializza una nuova variabile FinestraFile di tipo OpenFileDialog (OpenFileDialog visualizza una finestra che chiede di aprire un file)
            if (FinestraFile.ShowDialog() == DialogResult.OK)
            {
                TXT_File.Text = FinestraFile.FileName; //.FileName ottiene l'indirizzo del file selezionato sulla finestra
                Scelto = true; //aggiorno lo stato della variabile di stato
            }
            else
            {
                MessageBox.Show("Non hai selezionato un File. Selezionarne uno per continuare.", "ERRORE"); //errore in caso non abbiamo scelto un file. 
                return; //blocco la funzione
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
            if(Scelto) //se la variabile di stato risulta true, allora svolgiamo l'operazione di ricerca e visualizzazione
            {
                string Parola = TXT_Cognome.Text; //Legge cosa ho scritto sulla seconda textbox
                if(Parola == "")
                {
                    MessageBox.Show("Non hai inserito nessuna parola.", "ERRORE"); //errore in caso non abbiamo scritto niente nella textbox
                    return; //blocco la funzione
                }
                string SceltaCombobox = CBX_Scelta.Text; //legge cosa ho scelto nella combobox 
                if (SceltaCombobox == "")
                {
                    MessageBox.Show("Non hai scelto niente.", "ERRORE"); //errore in caso non abbiamo scelto niente nella combobox
                    return; //blocco la funzione
                }

                if (SceltaCombobox == "Inizia") 
                {
                    LST_Elenco.Items.Clear(); //pulisco la LISTBOX prima di scrivere
                    for (int i = 0; i < nRighe; i++)
                    {
                        if (Cognome[i].ToUpper().StartsWith(Parola.ToUpper())) //mando tutto in uppercase per evitare problemi inutili. Uso lo .StartsWith() per cercare i risultati combacianti.
                        {
                            LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]); //stampo i risultati.
                        }

                    }
                }
                else if (SceltaCombobox == "Contiene")
                {
                    LST_Elenco.Items.Clear(); //pulisco la LISTBOX prima di scrivere
                    for (int i = 0; i < nRighe; i++)
                    {
                        if (Cognome[i].ToUpper().Contains(Parola.ToUpper())) //mando tutto in uppercase per evitare problemi inutili. Uso lo .Contains() per cercare i risultati combacianti.
                        {
                            LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]); //stampo i risultati.
                        }

                    }
                }
                else if (SceltaCombobox == "Finisce") 
                {
                    LST_Elenco.Items.Clear(); //pulisco la LISTBOX prima di scrivere
                    for (int i = 0; i < nRighe; i++)
                    {
                        if (Cognome[i].ToUpper().EndsWith(Parola.ToUpper())) //mando tutto in uppercase per evitare problemi inutili. Uso lo .EndsWith() per cercare i risultati combacianti.
                        {
                            LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]); //stampo i risultati.
                        }

                    }
                }
                else if (SceltaCombobox == "Stampa Tutto")
                {
                    LST_Elenco.Items.Clear(); //pulisco la LISTBOX prima di scrivere 
                    for (int i = 0; i < nRighe; i++)
                    {
                        LST_Elenco.Items.Add(Nome[i] + " " + Cognome[i] + " " + Citta[i]); //stampo tutti i nomi cognomi e città contenute all'interno del file. 
                    }
                }
            }
            else
            {
                MessageBox.Show("Non hai inserito un file.", "ERRORE"); //in caso Scelto sia falso, mando il messaggio di errore e blocco la funzione.
                return;
            }
                
        }
    }
} 