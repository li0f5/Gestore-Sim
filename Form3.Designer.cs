namespace Gestore_Sim
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            iccidBox = new TextBox();
            nSimBox = new TextBox();
            iccidLabel = new Label();
            nSimLabel = new Label();
            consegnatoDaLabel = new Label();
            ok = new Button();
            tecnico = new ComboBox();
            consegnatoDa = new TextBox();
            consegnatoPer = new GroupBox();
            cliente = new TextBox();
            luogo = new TextBox();
            indirizzo = new TextBox();
            ragioneSociale = new TextBox();
            consegnatoPer.SuspendLayout();
            SuspendLayout();
            // 
            // iccidBox
            // 
            iccidBox.BackColor = SystemColors.Control;
            iccidBox.Location = new Point(68, 37);
            iccidBox.Name = "iccidBox";
            iccidBox.ReadOnly = true;
            iccidBox.ShortcutsEnabled = false;
            iccidBox.Size = new Size(216, 23);
            iccidBox.TabIndex = 0;
            iccidBox.TabStop = false;
            // 
            // nSimBox
            // 
            nSimBox.Location = new Point(68, 78);
            nSimBox.Name = "nSimBox";
            nSimBox.ReadOnly = true;
            nSimBox.Size = new Size(216, 23);
            nSimBox.TabIndex = 0;
            nSimBox.TabStop = false;
            // 
            // iccidLabel
            // 
            iccidLabel.AutoSize = true;
            iccidLabel.Location = new Point(12, 40);
            iccidLabel.Name = "iccidLabel";
            iccidLabel.Size = new Size(43, 15);
            iccidLabel.TabIndex = 0;
            iccidLabel.Text = "ICCID :";
            // 
            // nSimLabel
            // 
            nSimLabel.AutoSize = true;
            nSimLabel.Location = new Point(12, 81);
            nSimLabel.Name = "nSimLabel";
            nSimLabel.Size = new Size(50, 15);
            nSimLabel.TabIndex = 0;
            nSimLabel.Text = "N° SIM :";
            // 
            // consegnatoDaLabel
            // 
            consegnatoDaLabel.AutoSize = true;
            consegnatoDaLabel.Location = new Point(12, 114);
            consegnatoDaLabel.Name = "consegnatoDaLabel";
            consegnatoDaLabel.Size = new Size(91, 15);
            consegnatoDaLabel.TabIndex = 0;
            consegnatoDaLabel.Text = "consegnato da :";
            // 
            // ok
            // 
            ok.Location = new Point(226, 364);
            ok.Name = "ok";
            ok.Size = new Size(58, 34);
            ok.TabIndex = 7;
            ok.Text = "ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // tecnico
            // 
            tecnico.FormattingEnabled = true;
            tecnico.Location = new Point(12, 172);
            tecnico.Name = "tecnico";
            tecnico.Size = new Size(272, 23);
            tecnico.TabIndex = 2;
            tecnico.SelectedIndexChanged += tecnico_SelectedIndexChanged;
            // 
            // consegnatoDa
            // 
            consegnatoDa.AutoCompleteCustomSource.AddRange(new string[] { "(source)" });
            consegnatoDa.Location = new Point(12, 132);
            consegnatoDa.Name = "consegnatoDa";
            consegnatoDa.Size = new Size(272, 23);
            consegnatoDa.TabIndex = 1;
            // 
            // consegnatoPer
            // 
            consegnatoPer.BackColor = SystemColors.Control;
            consegnatoPer.Controls.Add(cliente);
            consegnatoPer.Controls.Add(luogo);
            consegnatoPer.Controls.Add(indirizzo);
            consegnatoPer.Controls.Add(ragioneSociale);
            consegnatoPer.Location = new Point(12, 201);
            consegnatoPer.Name = "consegnatoPer";
            consegnatoPer.Size = new Size(272, 146);
            consegnatoPer.TabIndex = 0;
            consegnatoPer.TabStop = false;
            consegnatoPer.Text = "conseganto per :";
            // 
            // cliente
            // 
            cliente.Location = new Point(6, 22);
            cliente.Name = "cliente";
            cliente.PlaceholderText = "Cliente :";
            cliente.Size = new Size(260, 23);
            cliente.TabIndex = 3;
            cliente.Click += cliente_Click;
            // 
            // luogo
            // 
            luogo.Location = new Point(6, 109);
            luogo.Name = "luogo";
            luogo.PlaceholderText = "Luogo :";
            luogo.Size = new Size(260, 23);
            luogo.TabIndex = 6;
            luogo.Click += luogo_Click;
            // 
            // indirizzo
            // 
            indirizzo.Location = new Point(6, 80);
            indirizzo.Name = "indirizzo";
            indirizzo.PlaceholderText = "Indirizzo :";
            indirizzo.Size = new Size(260, 23);
            indirizzo.TabIndex = 5;
            indirizzo.Click += indirizzo_Click;
            // 
            // ragioneSociale
            // 
            ragioneSociale.Location = new Point(6, 51);
            ragioneSociale.Name = "ragioneSociale";
            ragioneSociale.PlaceholderText = "Ragione Sociale :";
            ragioneSociale.Size = new Size(260, 23);
            ragioneSociale.TabIndex = 4;
            ragioneSociale.Click += ragioneSociale_Click;
            // 
            // Form3
            // 
            AcceptButton = ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 410);
            Controls.Add(consegnatoPer);
            Controls.Add(consegnatoDa);
            Controls.Add(tecnico);
            Controls.Add(ok);
            Controls.Add(consegnatoDaLabel);
            Controls.Add(nSimLabel);
            Controls.Add(iccidLabel);
            Controls.Add(nSimBox);
            Controls.Add(iccidBox);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form3";
            Text = "Asseganzione";
            consegnatoPer.ResumeLayout(false);
            consegnatoPer.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox iccidBox;
        private TextBox nSimBox;
        private Label iccidLabel;
        private Label nSimLabel;
        private Label consegnatoDaLabel;
        private Button ok;
        private ComboBox tecnico;
        private TextBox consegnatoDa;
        private GroupBox consegnatoPer;
        private TextBox luogo;
        private TextBox indirizzo;
        private TextBox ragioneSociale;
        private TextBox cliente;
    }
}