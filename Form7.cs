namespace Gestore_Sim
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void aggiungi_Click(object sender, EventArgs e)
        {
            if (utenteBox.Text != null)
            {
                if (pswBox.Text != null)
                {
                    GestoreSql.AggiungiUtente(utenteBox.Text, pswBox.Text);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("inserire password");
                }
            }
            else
            {
                MessageBox.Show("inserire nome utente");
            }

        }
        private static int i = 0;
        private void asterischi_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                pswBox.PasswordChar = '\0';
                i++;
            }
            else
            {
                pswBox.PasswordChar = '*';
                i--;
            }
        }
    }
}
