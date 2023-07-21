namespace Gestore_Sim
{
    partial class Form10
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form10));
            user = new TextBox();
            password = new TextBox();
            modifica = new Button();
            asterischi = new Button();
            SuspendLayout();
            // 
            // user
            // 
            user.Location = new Point(12, 12);
            user.Name = "user";
            user.Size = new Size(232, 23);
            user.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(12, 41);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(202, 23);
            password.TabIndex = 3;
            // 
            // modifica
            // 
            modifica.Location = new Point(12, 81);
            modifica.Name = "modifica";
            modifica.Size = new Size(232, 46);
            modifica.TabIndex = 1;
            modifica.Text = "modifica";
            modifica.UseVisualStyleBackColor = true;
            modifica.Click += modifica_Click;
            // 
            // asterischi
            // 
            asterischi.Location = new Point(214, 41);
            asterischi.Name = "asterischi";
            asterischi.Size = new Size(30, 23);
            asterischi.TabIndex = 4;
            asterischi.Text = "*";
            asterischi.UseVisualStyleBackColor = true;
            asterischi.Click += asterischi_Click;
            // 
            // Form10
            // 
            AcceptButton = modifica;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(256, 139);
            Controls.Add(asterischi);
            Controls.Add(modifica);
            Controls.Add(password);
            Controls.Add(user);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form10";
            Text = "Modifica";
            Load += Form10_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox user;
        private TextBox password;
        private Button modifica;
        private Button asterischi;
    }
}