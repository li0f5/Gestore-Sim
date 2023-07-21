namespace Gestore_Sim
{
    public partial class Form5 : Form
    {
        private int p;
        public Form5(int p)
        {
            InitializeComponent();
            this.p = p;
        }

        private void Form5_Load(object sender, EventArgs e)//viene riempita la listbox e se utente non ha i permessi vengono resi invisibili dei menu
        {
            ListaUpdate();
            if (p < 2)
            {
                telegramBotToolStripMenuItem.Enabled = false;
                telegramBotToolStripMenuItem.Visible = false;
                Elimina.Visible = false;
                Elimina.Enabled = false;
            }
        }

        private void ListaUpdate()
        {
            lista.BeginUpdate();
            lista.Items.Clear();
            lista.Items.AddRange(GestoreSql.ExportSimUsate().ToArray());
            lista.EndUpdate();
        }

        private void Elimina_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Sicuro di voler eliminare i dati selezionati?", "Rimozione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //condizione che controlla se e` stato premuto si sul messagebox
            if (result == DialogResult.Yes)
            {
                List<int> id = new List<int>();
                for (int i = 0; i < lista.CheckedItems.Count; i++)
                {
                    id.Add(((ClasseSimUsate)lista.CheckedItems[i]).getId());
                }
                if (lista.CheckedItems.Count > 0)
                {
                    GestoreSql.DelSimUsate(id.ToArray());
                }
                this.Close();
            }
        }

        private void barraInserimento_Click(object sender, EventArgs e)
        {
            barraInserimento.Text = string.Empty;
        }

        private void cerca_Click(object sender, EventArgs e)
        {
            string ricercato = barraInserimento.Text;
            ClasseSimUsate[] sims = GestoreSql.ExportSimUsate().ToArray();
            Boolean contenuto = false;
            //condizione che controlla la presenza di un iccid all'interno del textField
            if (ricercato != null)
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    //condizione che controlla la presenza della persona che consegna la sim corrispondente all'interno del textField
                    if (sims[i].getPresoDa() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
                    }
                    //condizione che controlla la presenza di un tecnico corrispondente all'interno del textField
                    else if (sims[i].getPresoA() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
                    }
                    //condizione che controlla la presenza di un cliente corrispondente all'interno del textField
                    else if (sims[i].getPresoPer() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
                    }
                    //condizione che controlla la presenza di un id corrispondente all'interno del textField
                    else if (sims[i].getId().ToString() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
                    }
                    //condizione che controlla la presenza di una sim corrispondente all'interno del textField
                    else if (GestoreSql.SimByIndice(sims[i].getId()).getSim().ToString() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
                    }
                    //condizione che controlla la presenza di un iccid corrispondente all'interno del textField
                    else if (GestoreSql.SimByIndice(sims[i].getId()).getIccid().ToString() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
                    }
                    //condizione che controlla la presenza di un iccid (aggiungendo 89 all'inizio caso mai non si fosse) corrispondente all'interno del textField
                    else if (!(ricercato.StartsWith("89")))
                    {
                        ricercato = "89" + ricercato;
                        if (GestoreSql.SimByIndice(sims[i].getId()).getIccid().ToString() == ricercato)
                        {
                            lista.SelectedIndex = i;
                            contenuto = true;
                            break;
                        }
                    }
                }
                if (!contenuto)
                {
                    MessageBox.Show("oggetto non trovato nella lista");
                }
            }
            else
            {
                MessageBox.Show("inserire un iccid");
            }
        }

        //richiama il metodo Scrittura della classe Gestore quando un solo elemento e` selezionato e viene premuto il tasto esporta
        private void esporta_Click(object sender, EventArgs e)
        {
            if (lista.CheckedIndices.Count == 1)
            {
                int i = lista.SelectedIndex;
                string sim = (ClasseSimUsate)lista.SelectedItem + "\t" + GestoreSql.SimByIndice(((ClasseSimUsate)lista.SelectedItem).getId()).getIccid().ToString() + "\t" + GestoreSql.SimByIndice(((ClasseSimUsate)lista.SelectedItem).getId()).getSim().ToString();
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.DefaultExt = "txt";
                sfd.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
                sfd.Title = "Stampa sim su file";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    Gestore.Scrittura(sfd.FileName, sim);
                }
            }
            else
            {
                MessageBox.Show("selezionare soltanto un oggetto");
            }
        }
        //-------------------------------------------------------------------------------------------------------------------------

        private void invio_Click(object sender, EventArgs e)//richiama il metodo Invio della classe Gestore quando un solo elemento e` selezionato e viene premuto il tasto invio
        {
            if (lista.CheckedIndices.Count == 1)
            {
                int i = lista.SelectedIndex;
                string presoDa = ((ClasseSimUsate)lista.SelectedItem).getPresoDa();
                string presoA = ((ClasseSimUsate)lista.SelectedItem).getPresoA();
                string presoPer = ((ClasseSimUsate)lista.SelectedItem).getPresoPer();
                string iccid = GestoreSql.SimByIndice(((ClasseSimUsate)lista.SelectedItem).getId()).getIccid().ToString();
                string sim = GestoreSql.SimByIndice(((ClasseSimUsate)lista.SelectedItem).getId()).getSim().ToString();

                Gestore.Invio(presoDa, presoA, presoPer, iccid, sim);
            }
            else
            {
                MessageBox.Show("selezionare soltanto un oggetto");
            }
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------

        private void telegramBotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form11().Show();
        }
    }
}
