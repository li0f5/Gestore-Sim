namespace Gestore_Sim
{
    public partial class Form8 : Form
    {
        private int p;
        public Form8(int p)
        {
            this.p = p;
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            ListaUpdate();
        }

        private void ListaUpdate()
        {
            lista.BeginUpdate();
            lista.Items.Clear();
            lista.Items.AddRange(GestoreSql.ExportUtenti(p).ToArray());
            lista.EndUpdate();
        }

        private void elimina_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                string[] cred = lista.SelectedItem.ToString().Split("\t");
                string utente = cred[1];
                string pasw = cred[3];
                var result = MessageBox.Show("Sicuro di voler eliminare i dati selezionati?", "Rimozione", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    GestoreSql.Eliminautente(utente, pasw, p);
                    this.Close();
                }
            }
            ListaUpdate();
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItems.Count > 0)
            {
                string[] cred = lista.SelectedItem.ToString().Split("\t");
                string utente = cred[1];
                string pasw = cred[3];
                string priv = cred[5];
                new Form9(utente, pasw, priv, p).ShowDialog();
            }
            ListaUpdate();
        }
    }
}
