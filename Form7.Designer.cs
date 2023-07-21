namespace Gestore_Sim
{
    partial class Form7
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form7));
            aggiungi = new Button();
            utenteBox = new TextBox();
            pswBox = new TextBox();
            asterischi = new Button();
            SuspendLayout();
            // 
            // aggiungi
            // 
            aggiungi.Location = new Point(12, 70);
            aggiungi.Name = "aggiungi";
            aggiungi.Size = new Size(238, 32);
            aggiungi.TabIndex = 1;
            aggiungi.Text = "aggiungi";
            aggiungi.UseVisualStyleBackColor = true;
            aggiungi.Click += aggiungi_Click;
            // 
            // utenteBox
            // 
            utenteBox.Location = new Point(12, 12);
            utenteBox.Name = "utenteBox";
            utenteBox.PlaceholderText = "nome utente";
            utenteBox.Size = new Size(238, 23);
            utenteBox.TabIndex = 2;
            // 
            // pswBox
            // 
            pswBox.Location = new Point(12, 41);
            pswBox.Name = "pswBox";
            pswBox.PasswordChar = '*';
            pswBox.PlaceholderText = "password";
            pswBox.Size = new Size(208, 23);
            pswBox.TabIndex = 3;
            // 
            // asterischi
            // 
            asterischi.Location = new Point(226, 41);
            asterischi.Name = "asterischi";
            asterischi.Size = new Size(24, 23);
            asterischi.TabIndex = 4;
            asterischi.Text = "*";
            asterischi.UseVisualStyleBackColor = true;
            asterischi.Click += asterischi_Click;
            // 
            // Form7
            // 
            AcceptButton = aggiungi;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(262, 114);
            Controls.Add(asterischi);
            Controls.Add(pswBox);
            Controls.Add(utenteBox);
            Controls.Add(aggiungi);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form7";
            Text = "Aggiungi Utente";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button aggiungi;
        private TextBox utenteBox;
        private TextBox pswBox;
        private Button asterischi;
    }
}