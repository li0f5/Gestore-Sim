namespace Gestore_Sim
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void ListaUpdate()
        {
            log.BeginUpdate();
            log.Items.Clear();
            log.Items.AddRange(GestoreSql.ExportLog().ToArray());
            log.EndUpdate();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            ListaUpdate();
        }
    }
}
