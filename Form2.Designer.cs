namespace Gestore_Sim
{
    partial class Form2
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            cerca = new Button();
            assegna = new Button();
            lista = new ListBox();
            barraInserimento = new TextBox();
            fileToolStripMenuItem = new ToolStripMenuItem();
            importareFilecsvToolStripMenuItem = new ToolStripMenuItem();
            logToolStripMenuItem = new ToolStripMenuItem();
            utentiToolStripMenuItem = new ToolStripMenuItem();
            aggiuToolStripMenuItem = new ToolStripMenuItem();
            gestireToolStripMenuItem = new ToolStripMenuItem();
            modificaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            serverSqlToolStripMenuItem = new ToolStripMenuItem();
            elimina = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // cerca
            // 
            cerca.Location = new Point(355, 27);
            cerca.Name = "cerca";
            cerca.Size = new Size(91, 23);
            cerca.TabIndex = 2;
            cerca.Text = "cerca";
            cerca.UseVisualStyleBackColor = true;
            cerca.Click += cerca_Click;
            // 
            // assegna
            // 
            assegna.Location = new Point(505, 71);
            assegna.Name = "assegna";
            assegna.Size = new Size(131, 113);
            assegna.TabIndex = 4;
            assegna.Text = "assegna";
            assegna.UseVisualStyleBackColor = true;
            assegna.Click += assegna_Click;
            // 
            // lista
            // 
            lista.FormattingEnabled = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 71);
            lista.Name = "lista";
            lista.Size = new Size(487, 439);
            lista.TabIndex = 3;
            // 
            // barraInserimento
            // 
            barraInserimento.Cursor = Cursors.IBeam;
            barraInserimento.Location = new Point(132, 27);
            barraInserimento.Name = "barraInserimento";
            barraInserimento.PlaceholderText = "inserire ICCID";
            barraInserimento.Size = new Size(217, 23);
            barraInserimento.TabIndex = 1;
            barraInserimento.Click += barraInserimento_Click;
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { importareFilecsvToolStripMenuItem, logToolStripMenuItem, utentiToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(50, 20);
            fileToolStripMenuItem.Text = "Menu";
            // 
            // importareFilecsvToolStripMenuItem
            // 
            importareFilecsvToolStripMenuItem.Name = "importareFilecsvToolStripMenuItem";
            importareFilecsvToolStripMenuItem.Size = new Size(180, 22);
            importareFilecsvToolStripMenuItem.Text = "Importare file.csv";
            importareFilecsvToolStripMenuItem.Click += importareFilecsvToolStripMenuItem_Click;
            // 
            // logToolStripMenuItem
            // 
            logToolStripMenuItem.Name = "logToolStripMenuItem";
            logToolStripMenuItem.Size = new Size(180, 22);
            logToolStripMenuItem.Text = "Log";
            logToolStripMenuItem.Click += logToolStripMenuItem_Click;
            // 
            // utentiToolStripMenuItem
            // 
            utentiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aggiuToolStripMenuItem, gestireToolStripMenuItem, modificaToolStripMenuItem });
            utentiToolStripMenuItem.Name = "utentiToolStripMenuItem";
            utentiToolStripMenuItem.Size = new Size(180, 22);
            utentiToolStripMenuItem.Text = "Utenti";
            // 
            // aggiuToolStripMenuItem
            // 
            aggiuToolStripMenuItem.Name = "aggiuToolStripMenuItem";
            aggiuToolStripMenuItem.Size = new Size(180, 22);
            aggiuToolStripMenuItem.Text = "Aggiungere";
            aggiuToolStripMenuItem.Click += aggiuToolStripMenuItem_Click;
            // 
            // gestireToolStripMenuItem
            // 
            gestireToolStripMenuItem.Name = "gestireToolStripMenuItem";
            gestireToolStripMenuItem.Size = new Size(180, 22);
            gestireToolStripMenuItem.Text = "Gestire";
            gestireToolStripMenuItem.Click += gestireToolStripMenuItem_Click;
            // 
            // modificaToolStripMenuItem
            // 
            modificaToolStripMenuItem.Name = "modificaToolStripMenuItem";
            modificaToolStripMenuItem.Size = new Size(180, 22);
            modificaToolStripMenuItem.Text = "Modifica";
            modificaToolStripMenuItem.Click += modificaToolStripMenuItem_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, serverSqlToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(648, 24);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // serverSqlToolStripMenuItem
            // 
            serverSqlToolStripMenuItem.Name = "serverSqlToolStripMenuItem";
            serverSqlToolStripMenuItem.Size = new Size(70, 20);
            serverSqlToolStripMenuItem.Text = "Server Sql";
            serverSqlToolStripMenuItem.Click += serverSqlToolStripMenuItem_Click;
            // 
            // elimina
            // 
            elimina.Location = new Point(505, 397);
            elimina.Name = "elimina";
            elimina.Size = new Size(131, 113);
            elimina.TabIndex = 5;
            elimina.Text = "sim assegnate";
            elimina.UseVisualStyleBackColor = true;
            elimina.Click += elimina_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(648, 533);
            Controls.Add(elimina);
            Controls.Add(barraInserimento);
            Controls.Add(lista);
            Controls.Add(assegna);
            Controls.Add(cerca);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form2";
            Text = "Gestore Sim";
            Load += Form2_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button cerca;
        private Button assegna;
        private ListBox lista;
        private TextBox barraInserimento;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem importareFilecsvToolStripMenuItem;
        private MenuStrip menuStrip1;
        private Button elimina;
        private ToolStripMenuItem logToolStripMenuItem;
        private ToolStripMenuItem utentiToolStripMenuItem;
        private ToolStripMenuItem aggiuToolStripMenuItem;
        private ToolStripMenuItem gestireToolStripMenuItem;
        private ToolStripMenuItem modificaToolStripMenuItem;
        private ToolStripMenuItem serverSqlToolStripMenuItem;
    }
}