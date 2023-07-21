namespace Gestore_Sim
{
    partial class Form12
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            idBox = new TextBox();
            pswBox = new TextBox();
            serverBox = new TextBox();
            collega = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 15);
            label1.Name = "label1";
            label1.Size = new Size(23, 15);
            label1.TabIndex = 0;
            label1.Text = "id: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 44);
            label2.Name = "label2";
            label2.Size = new Size(63, 15);
            label2.TabIndex = 0;
            label2.Text = "password: ";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 73);
            label3.Name = "label3";
            label3.Size = new Size(44, 15);
            label3.TabIndex = 0;
            label3.Text = "server: ";
            // 
            // idBox
            // 
            idBox.Location = new Point(81, 12);
            idBox.Name = "idBox";
            idBox.PlaceholderText = "id";
            idBox.Size = new Size(168, 23);
            idBox.TabIndex = 2;
            // 
            // pswBox
            // 
            pswBox.Location = new Point(81, 41);
            pswBox.Name = "pswBox";
            pswBox.PlaceholderText = "password";
            pswBox.Size = new Size(168, 23);
            pswBox.TabIndex = 3;
            // 
            // serverBox
            // 
            serverBox.Location = new Point(81, 70);
            serverBox.Name = "serverBox";
            serverBox.PlaceholderText = "server ip";
            serverBox.Size = new Size(168, 23);
            serverBox.TabIndex = 4;
            // 
            // collega
            // 
            collega.Location = new Point(12, 99);
            collega.Name = "collega";
            collega.Size = new Size(237, 47);
            collega.TabIndex = 1;
            collega.Text = "Collega";
            collega.UseVisualStyleBackColor = true;
            collega.Click += collega_Click;
            // 
            // Form12
            // 
            AcceptButton = collega;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(261, 158);
            Controls.Add(collega);
            Controls.Add(serverBox);
            Controls.Add(pswBox);
            Controls.Add(idBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form12";
            Text = "Server Sql";
            Load += Form12_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox idBox;
        private TextBox pswBox;
        private TextBox serverBox;
        private Button collega;
    }
}