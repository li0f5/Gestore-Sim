namespace Gestore_Sim
{
    public partial class Form11 : Form
    {
        public Form11()
        {
            InitializeComponent();
        }

        private void ok_Click(object sender, EventArgs e)
        {
            string token = tokenBox.Text;
            if (chatBox.SelectedItem != null)
            {
                Gestore.SetChatId(chatBox.SelectedItem.ToString());
                this.Close();
            }
            if (token != null)
            {
                Gestore.SetToken(token);
                this.Close();
            }
        }

        private void Form11_Load(object sender, EventArgs e)
        {
            tokenBox.Text = Gestore.GetToken();
            chatBox.Items.Clear();
            chatBox.Text = Gestore.GetChatId();
            chatBox.Items.Add(Gestore.GetChatId());
            chatBox.Items.AddRange(Gestore.GetChats().ToArray());
        }
    }
}
