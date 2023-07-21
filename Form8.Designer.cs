namespace Gestore_Sim
{
    partial class Form8
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            lista = new ListBox();
            elimina = new Button();
            modifica = new Button();
            SuspendLayout();
            // 
            // lista
            // 
            lista.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lista.FormattingEnabled = true;
            lista.HorizontalScrollbar = true;
            lista.ItemHeight = 15;
            lista.Location = new Point(12, 12);
            lista.Name = "lista";
            lista.Size = new Size(576, 229);
            lista.TabIndex = 1;
            // 
            // elimina
            // 
            elimina.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            elimina.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            elimina.Location = new Point(12, 247);
            elimina.Name = "elimina";
            elimina.Size = new Size(288, 53);
            elimina.TabIndex = 2;
            elimina.Text = "elimina";
            elimina.UseVisualStyleBackColor = true;
            elimina.Click += elimina_Click;
            // 
            // modifica
            // 
            modifica.Location = new Point(300, 247);
            modifica.Name = "modifica";
            modifica.Size = new Size(288, 53);
            modifica.TabIndex = 3;
            modifica.Text = "modifica";
            modifica.UseVisualStyleBackColor = true;
            modifica.Click += modifica_Click;
            // 
            // Form8
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(600, 312);
            Controls.Add(modifica);
            Controls.Add(elimina);
            Controls.Add(lista);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            MinimumSize = new Size(382, 351);
            Name = "Form8";
            Text = "Gestire Utenti";
            Load += Form8_Load;
            ResumeLayout(false);
        }

        #endregion

        private ListBox lista;
        private Button elimina;
        private Button modifica;
    }
}