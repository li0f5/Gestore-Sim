namespace Gestore_Sim
{
    public partial class Form2 : Form
    {
        private string utente;
        private string psw;
        private int p;
        public Form2(string utente, string psw, int p)
        {
            InitializeComponent();
            this.utente = utente;
            this.psw = psw;
            this.p = p;
        }
        private void Form2_Load(object sender, EventArgs e)//viene riempita la listbox e se utente non ha i permessi vengono resi invisibili dei menu
        {
            ListaUpdate();
            if (p < 2)
            {
                importareFilecsvToolStripMenuItem.Enabled = false;
                importareFilecsvToolStripMenuItem.Visible = false;
                aggiuToolStripMenuItem.Enabled = false;
                aggiuToolStripMenuItem.Visible = false;
                gestireToolStripMenuItem.Enabled = false;
                gestireToolStripMenuItem.Visible = false;
                assegna.Visible = false;
                assegna.Enabled = false;
            }
        }

        private void ListaUpdate()
        {
            lista.BeginUpdate();
            lista.Items.Clear();
            lista.Items.AddRange(GestoreSql.ExportSim().ToArray());
            lista.EndUpdate();
        }

        private void barraInserimento_Click(object sender, EventArgs e)
        {
            barraInserimento.Text = string.Empty;
        }

        private void cerca_Click(object sender, EventArgs e)
        {
            string ricercato = barraInserimento.Text;
            ClasseSim[] sims = GestoreSql.ExportSim().ToArray();
            Boolean contenuto = false;
            //condizione che controlla la presenza di un iccid all'interno del textField
            if (ricercato != "")
            {
                for (int i = 0; i < lista.Items.Count; i++)
                {
                    if (!(ricercato.StartsWith("89"))) { ricercato = "89" + ricercato; }
                    //condizione che controlla la presenza di un iccid valido all'interno del textField
                    if (sims[i].getIccid().ToString() == ricercato)
                    {
                        lista.SelectedIndex = i;
                        contenuto = true;
                        break;
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

        private void assegna_Click(object sender, EventArgs e)
        {
            int index = lista.SelectedIndex;
            //condizione per controllare che sia sellezionato un oggetto della listBox
            if (index != -1)
            {
                new Form3(lista.SelectedItem as ClasseSim, utente).ShowDialog();
                ListaUpdate();
            }
            else
            {
                MessageBox.Show("selezionare voce dalla lista");
            }
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form5(p).ShowDialog();
            ListaUpdate();
            this.Visible = true;
        }

        private void importareFilecsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                ClasseSim[] sims = Gestore.Lettura(ofd.FileName);
                GestoreSql.ImportSim(sims);
            }
            lista.BeginUpdate();
            lista.Items.Clear();
            lista.Items.AddRange(GestoreSql.ExportSim().ToArray());
            lista.EndUpdate();
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form6().ShowDialog();
            ListaUpdate();
            this.Visible = true;
        }

        private void aggiuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form7().ShowDialog();
        }

        private void gestireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            new Form8(p).ShowDialog();
            this.Visible = true;
        }

        private void modificaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form10(utente, psw, p).ShowDialog();
        }

        private void serverSqlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form12().ShowDialog();
        }
    }
}
