namespace Gestore_Sim
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void aggiungiButton_Click(object sender, EventArgs e)
        {
            if (nomeBox.Text != null && cognomeBox.Text != null)
            {
                GestoreSql.NuovoTecnico(nomeBox.Text, cognomeBox.Text, dittaBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("inserire nome e cognome nelle apposite caselle");
            }
        }
    }
}
