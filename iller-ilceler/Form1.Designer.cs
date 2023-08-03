namespace iller_ilceler
{
    partial class Form1
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
            cbIller = new ComboBox();
            cbIlceler = new ComboBox();
            SuspendLayout();
            // 
            // cbIller
            // 
            cbIller.BackColor = SystemColors.Menu;
            cbIller.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            cbIller.FormattingEnabled = true;
            cbIller.Location = new Point(41, 37);
            cbIller.Margin = new Padding(4);
            cbIller.Name = "cbIller";
            cbIller.Size = new Size(279, 38);
            cbIller.TabIndex = 0;
            cbIller.Text = "İl Seçiniz";
            cbIller.SelectedIndexChanged += cbIller_SelectedIndexChanged;
            cbIller.TextChanged += cbIller_TextChanged;
            // 
            // cbIlceler
            // 
            cbIlceler.BackColor = SystemColors.Menu;
            cbIlceler.FormattingEnabled = true;
            cbIlceler.Location = new Point(39, 133);
            cbIlceler.Margin = new Padding(4);
            cbIlceler.Name = "cbIlceler";
            cbIlceler.Size = new Size(284, 38);
            cbIlceler.TabIndex = 1;
            cbIlceler.Text = "İlçe Seçiniz";
            cbIlceler.TextChanged += cbIlceler_TextChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(13F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(783, 528);
            Controls.Add(cbIlceler);
            Controls.Add(cbIller);
            Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
        }

        #endregion

        private ComboBox cbIller;
        private ComboBox cbIlceler;
    }
}