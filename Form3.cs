namespace Gestore_Sim
{
    public partial class Form3 : Form
    {
        private ClasseSim sim;
        private ListBox lista;
        internal Form3(ClasseSim sim, string utente)
        {
            InitializeComponent();
            consegnatoDa.Text = utente;
            //inizializzo il contenuto dei due textField
            iccidBox.Text = sim.getIccid().ToString();
            nSimBox.Text = sim.getSim().ToString();
            //------------------------------------------
            //inizializzo il contenuto della ComboBox
            tecnico.Text = "consegnato da:";
            tecnico.Items.Add("Aggiungi :");
            tecnico.Items.AddRange(GestoreSql.ExportTecnici());
            //---------------------------------------
            this.sim = sim;
        }

        private void ok_Click(object sender, EventArgs e)
        {

            if (consegnatoDa.Text == "")
            {
                consegnatoDa.Text = "Sem";
            }
            if (ragioneSociale.Text != "" && indirizzo.Text != "" && luogo.Text != "")
            {
                if (tecnico.SelectedIndex != -1)
                {
                    GestoreSql.Cliente(cliente.Text, ragioneSociale.Text, indirizzo.Text, luogo.Text);
                    GestoreSql.ImportSimUsate(sim.getId(), consegnatoDa.Text, cliente.Text, tecnico.SelectedItem.ToString());
                    this.Close();
                }
                else
                {
                    MessageBox.Show("selezionare il personale che consegnera");
                }
            }
            else
            {
                MessageBox.Show("inserire i dati nei campi corrispondenti al cliente");
            }
        }

        private void tecnico_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tecnico.SelectedIndex == 0)
            {
                ok.Visible = false;
                new Form4().ShowDialog();
                tecnico.BeginUpdate();
                tecnico.Items.Clear();
                tecnico.Items.Add("Aggiungi :");
                tecnico.Items.AddRange(GestoreSql.ExportTecnici());
                tecnico.EndUpdate();
                ok.Visible = true;
            }
        }

        private void cliente_Click(object sender, EventArgs e)
        {
            cliente.Text = string.Empty;
        }

        private void ragioneSociale_Click(object sender, EventArgs e)
        {
            ragioneSociale.Text = string.Empty;
        }

        private void indirizzo_Click(object sender, EventArgs e)
        {
            indirizzo.Text = string.Empty;
        }

        private void luogo_Click(object sender, EventArgs e)
        {
            luogo.Text = string.Empty;
        }
    }
}
