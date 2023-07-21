namespace Gestore_Sim
{
    public partial class Form12 : Form
    {
        public Form12()
        {
            InitializeComponent();
        }

        private void collega_Click(object sender, EventArgs e)
        {
            if (idBox.Text != null && pswBox.Text != null && serverBox.Text != null)
            {
                GestoreSql.SetConnesione(idBox.Text, pswBox.Text, serverBox.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("riempire tutti i campi");
            }
        }

        private void Form12_Load(object sender, EventArgs e)
        {
            string[] credenziali = GestoreSql.GetConnesione().Split("-");
            idBox.Text = credenziali[0];
            pswBox.Text = credenziali[1];
            serverBox.Text = credenziali[2];
        }
    }
}
