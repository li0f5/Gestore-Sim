namespace Gestore_Sim
{
    partial class Form11
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form11));
            ok = new Button();
            tokenBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            chatBox = new ComboBox();
            SuspendLayout();
            // 
            // ok
            // 
            ok.Location = new Point(425, 26);
            ok.Name = "ok";
            ok.Size = new Size(30, 52);
            ok.TabIndex = 1;
            ok.Text = "ok";
            ok.UseVisualStyleBackColor = true;
            ok.Click += ok_Click;
            // 
            // tokenBox
            // 
            tokenBox.AllowDrop = true;
            tokenBox.Location = new Point(12, 26);
            tokenBox.Name = "tokenBox";
            tokenBox.Size = new Size(407, 23);
            tokenBox.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 5);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Bot token: ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 58);
            label2.Name = "label2";
            label2.Size = new Size(48, 15);
            label2.TabIndex = 0;
            label2.Text = "Chat Id:";
            // 
            // chatBox
            // 
            chatBox.FormattingEnabled = true;
            chatBox.Location = new Point(66, 55);
            chatBox.Name = "chatBox";
            chatBox.Size = new Size(353, 23);
            chatBox.TabIndex = 3;
            // 
            // Form11
            // 
            AcceptButton = ok;
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(467, 91);
            Controls.Add(chatBox);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tokenBox);
            Controls.Add(ok);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form11";
            Text = "Telegram Bot";
            Load += Form11_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button ok;
        private TextBox tokenBox;
        private Label label1;
        private Label label2;
        private ComboBox chatBox;
    }
}