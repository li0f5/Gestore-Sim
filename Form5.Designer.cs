namespace Gestore_Sim
{
    partial class Form5
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            lista = new CheckedListBox();
            Elimina = new Button();
            barraInserimento = new TextBox();
            cerca = new Button();
            esporta = new Button();
            invio = new Button();
            menuStrip1 = new MenuStrip();
            telegramBotToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // lista
            // 
            lista.CheckOnClick = true;
            lista.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lista.FormattingEnabled = true;
            lista.Location = new Point(12, 61);
            lista.Name = "lista";
            lista.Size = new Size(395, 316);
            lista.TabIndex = 3;
            // 
            // Elimina
            // 
            Elimina.Location = new Point(279, 392);
            Elimina.Name = "Elimina";
            Elimina.Size = new Size(128, 46);
            Elimina.TabIndex = 6;
            Elimina.Text = "Elimina";
            Elimina.UseVisualStyleBackColor = true;
            Elimina.Click += Elimina_Click;
            // 
            // barraInserimento
            // 
            barraInserimento.Location = new Point(12, 27);
            barraInserimento.Name = "barraInserimento";
            barraInserimento.Size = new Size(298, 23);
            barraInserimento.TabIndex = 1;
            barraInserimento.Click += barraInserimento_Click;
            // 
            // cerca
            // 
            cerca.Location = new Point(316, 27);
            cerca.Name = "cerca";
            cerca.Size = new Size(91, 23);
            cerca.TabIndex = 2;
            cerca.Text = "cerca";
            cerca.UseVisualStyleBackColor = true;
            cerca.Click += cerca_Click;
            // 
            // esporta
            // 
            esporta.Location = new Point(12, 392);
            esporta.Name = "esporta";
            esporta.Size = new Size(128, 46);
            esporta.TabIndex = 4;
            esporta.Text = "Salva su file";
            esporta.UseVisualStyleBackColor = true;
            esporta.Click += esporta_Click;
            // 
            // invio
            // 
            invio.Location = new Point(146, 392);
            invio.Name = "invio";
            invio.Size = new Size(128, 46);
            invio.TabIndex = 5;
            invio.Text = "Invia su telegram";
            invio.UseVisualStyleBackColor = true;
            invio.Click += invio_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { telegramBotToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(419, 24);
            menuStrip1.TabIndex = 6;
            menuStrip1.Text = "menuStrip1";
            // 
            // telegramBotToolStripMenuItem
            // 
            telegramBotToolStripMenuItem.Name = "telegramBotToolStripMenuItem";
            telegramBotToolStripMenuItem.Size = new Size(88, 20);
            telegramBotToolStripMenuItem.Text = "Telegram Bot";
            telegramBotToolStripMenuItem.Click += telegramBotToolStripMenuItem_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(419, 450);
            Controls.Add(invio);
            Controls.Add(esporta);
            Controls.Add(cerca);
            Controls.Add(barraInserimento);
            Controls.Add(Elimina);
            Controls.Add(lista);
            Controls.Add(menuStrip1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form5";
            Text = "Sim Assegnate";
            Load += Form5_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox lista;
        private Button Elimina;
        private TextBox barraInserimento;
        private Button cerca;
        private Button esporta;
        private Button invio;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem telegramBotToolStripMenuItem;
    }
}