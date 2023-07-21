namespace Gestore_Sim
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            label1 = new Label();
            label2 = new Label();
            nomeBox = new TextBox();
            cognomeBox = new TextBox();
            aggiungiButton = new Button();
            label3 = new Label();
            dittaBox = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(46, 15);
            label1.TabIndex = 0;
            label1.Text = "Nome :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 38);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 0;
            label2.Text = "Cognome :";
            // 
            // nomeBox
            // 
            nomeBox.Location = new Point(81, 6);
            nomeBox.Name = "nomeBox";
            nomeBox.Size = new Size(211, 23);
            nomeBox.TabIndex = 2;
            // 
            // cognomeBox
            // 
            cognomeBox.Location = new Point(81, 35);
            cognomeBox.Name = "cognomeBox";
            cognomeBox.Size = new Size(211, 23);
            cognomeBox.TabIndex = 3;
            // 
            // aggiungiButton
            // 
            aggiungiButton.Location = new Point(12, 93);
            aggiungiButton.Name = "aggiungiButton";
            aggiungiButton.Size = new Size(280, 40);
            aggiungiButton.TabIndex = 1;
            aggiungiButton.Text = "aggiungi";
            aggiungiButton.UseVisualStyleBackColor = true;
            aggiungiButton.Click += aggiungiButton_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 67);
            label3.Name = "label3";
            label3.Size = new Size(35, 15);
            label3.TabIndex = 0;
            label3.Text = "Ditta:";
            // 
            // dittaBox
            // 
            dittaBox.Location = new Point(81, 64);
            dittaBox.Name = "dittaBox";
            dittaBox.Size = new Size(211, 23);
            dittaBox.TabIndex = 4;
            // 
            // Form4
            // 
            AcceptButton = aggiungiButton;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(304, 145);
            Controls.Add(dittaBox);
            Controls.Add(label3);
            Controls.Add(aggiungiButton);
            Controls.Add(cognomeBox);
            Controls.Add(nomeBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form4";
            Text = "Aggiungi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox nomeBox;
        private TextBox cognomeBox;
        private Button aggiungiButton;
        private Label label3;
        private TextBox dittaBox;
    }
}