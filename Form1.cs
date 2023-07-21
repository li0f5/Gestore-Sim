namespace Gestore_Sim
{
    public partial class Form1 : Form
    {
        private static string utente;
        private static string psw;
        private static int p;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)//effettua una prova di connesione al server mentre il form viene caricato
        {
            Test(0);
        }

        private bool Test(int i)//metodo che testa la connesione al server meidante la chiamata al metodo ExportLog della classe GestoreSql
        {
            bool b = false;
            try
            {
                GestoreSql.ExportLog();
                b = true;
            }
            catch (Exception ex)
            {
                if (i == 0)
                {
                    MessageBox.Show(ex.Message, "errore");
                }
                else
                {
                    new Form12().ShowDialog();
                }
            }
            return b;
        }

        private void newForm()
        {
            this.Visible = false;
            new Form2(utente, psw, p).ShowDialog();
            this.Visible = true;
        }

        private void accedi_Click(object sender, EventArgs e)
        {
            //controlla che le caselle di testo di utente e password non siano vuote
            if (user.Text != string.Empty && password.Text != string.Empty)
            {
                if (Test(0))//viene ricontrollato se la connesione al server e` presente
                {
                    if (user.Text == "super" && password.Text == "super")
                    {
                        utente = "super";
                        psw = "super";
                        p = 3;
                        user.ResetText();
                        password.ResetText();
                        newForm();
                    }
                    else if (GestoreSql.Accesso(user.Text, password.Text))
                    {
                        utente = user.Text;
                        psw = password.Text;
                        p = GestoreSql.GetPrivilegi(utente, psw);
                        user.ResetText();
                        password.ResetText();
                        newForm();
                    }
                    else
                    {
                        MessageBox.Show("Password o nome utente sbagliati");
                    }
                }
                else if (user.Text == "super" && password.Text == "super")//se la connesione al server fallisce ma l'utente e password corrispondono 
                {                                                         //a super si apre un form per cambiare le proprieta della connesione al server
                    p = 3;
                    Test(p);
                }
                else
                {
                    MessageBox.Show("connesione non riuscita");
                }
            }
            else
            {
                MessageBox.Show("Inserire nome utente e password");
            }

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