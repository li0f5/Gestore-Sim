namespace Gestore_Sim
{
    partial class Form9
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form9));
            modifica = new Button();
            utenteBox = new TextBox();
            pswBox = new TextBox();
            asterischi = new Button();
            priv = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)priv).BeginInit();
            SuspendLayout();
            // 
            // modifica
            // 
            modifica.Location = new Point(12, 99);
            modifica.Name = "modifica";
            modifica.Size = new Size(238, 32);
            modifica.TabIndex = 1;
            modifica.Text = "modifica";
            modifica.UseVisualStyleBackColor = true;
            modifica.Click += modifica_Click;
            // 
            // utenteBox
            // 
            utenteBox.Location = new Point(12, 12);
            utenteBox.Name = "utenteBox";
            utenteBox.Size = new Size(238, 23);
            utenteBox.TabIndex = 2;
            // 
            // pswBox
            // 
            pswBox.Location = new Point(12, 41);
            pswBox.Name = "pswBox";
            pswBox.PasswordChar = '*';
            pswBox.Size = new Size(208, 23);
            pswBox.TabIndex = 3;
            // 
            // asterischi
            // 
            asterischi.Location = new Point(226, 41);
            asterischi.Name = "asterischi";
            asterischi.Size = new Size(24, 23);
            asterischi.TabIndex = 5;
            asterischi.Text = "*";
            asterischi.UseVisualStyleBackColor = true;
            asterischi.Click += asterischi_Click;
            // 
            // priv
            // 
            priv.Location = new Point(12, 70);
            priv.Maximum = new decimal(new int[] { 2, 0, 0, 0 });
            priv.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            priv.Name = "priv";
            priv.Size = new Size(238, 23);
            priv.TabIndex = 4;
            priv.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // Form9
            // 
            AcceptButton = modifica;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 143);
            Controls.Add(priv);
            Controls.Add(asterischi);
            Controls.Add(pswBox);
            Controls.Add(utenteBox);
            Controls.Add(modifica);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form9";
            Text = "Aggiungi Utente";
            Load += Form9_Load;
            ((System.ComponentModel.ISupportInitialize)priv).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button modifica;
        private TextBox utenteBox;
        private TextBox pswBox;
        private Button asterischi;
        private NumericUpDown priv;
    }
}