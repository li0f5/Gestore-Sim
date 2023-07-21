namespace Gestore_Sim
{
    public partial class Form9 : Form
    {
        private string user;
        private string password;
        private string privi;
        private int p;
        public Form9(string user, string psw, string privi, int p)
        {
            this.user = user;
            this.password = psw;
            this.privi = privi;
            this.p = p;
            InitializeComponent();
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            utenteBox.Text = user;
            pswBox.Text = password;
            priv.Value = Convert.ToInt32(privi);
            priv.Maximum = p;
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            GestoreSql.ModificaUtente(utenteBox.Text, pswBox.Text, user, password, Convert.ToInt32(priv.Value));
            this.Close();
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
