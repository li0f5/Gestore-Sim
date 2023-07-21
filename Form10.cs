namespace Gestore_Sim
{
    public partial class Form10 : Form
    {
        private string utente;
        private string psw;
        private int p;
        public Form10(string utente, string psw, int p)
        {
            InitializeComponent();
            this.utente = utente;
            this.psw = psw;
            this.p = p;
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            user.Text = utente;
            password.Text = psw;
        }

        private void modifica_Click(object sender, EventArgs e)
        {
            GestoreSql.ModificaUtente(user.Text, password.Text, utente, psw, p);
            this.Close();
        }

        private static int i = 0;
        private void asterischi_Click(object sender, EventArgs e)
        {
            if (i == 0)
            {
                password.PasswordChar = '\0';
                i++;
            }
            else
            {
                password.PasswordChar = '*';
                i--;
            }
        }
    }
}
