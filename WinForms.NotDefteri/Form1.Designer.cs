namespace WinForms.NotDefteri
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            txtNote = new RichTextBox();
            label1 = new Label();
            btnEkle = new Button();
            btnSil = new Button();
            btnGuncelle = new Button();
            btnCikis = new Button();
            listBox1 = new CheckedListBox();
            lblYap = new Label();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // txtNote
            // 
            txtNote.BackColor = SystemColors.HighlightText;
            txtNote.Location = new Point(349, 42);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(292, 79);
            txtNote.TabIndex = 1;
            txtNote.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(441, 9);
            label1.Name = "label1";
            label1.Size = new Size(120, 33);
            label1.TabIndex = 13;
            label1.Text = "NOT YAZ";
            // 
            // btnEkle
            // 
            btnEkle.BackColor = Color.Transparent;
            btnEkle.Cursor = Cursors.Hand;
            btnEkle.FlatAppearance.BorderColor = Color.Black;
            btnEkle.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnEkle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnEkle.FlatStyle = FlatStyle.Flat;
            btnEkle.Location = new Point(349, 129);
            btnEkle.Name = "btnEkle";
            btnEkle.Size = new Size(138, 49);
            btnEkle.TabIndex = 2;
            btnEkle.Text = "EKLE";
            btnEkle.UseVisualStyleBackColor = false;
            btnEkle.Click += btnEkle_Click;
            // 
            // btnSil
            // 
            btnSil.Cursor = Cursors.Hand;
            btnSil.FlatAppearance.BorderColor = Color.Black;
            btnSil.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnSil.FlatStyle = FlatStyle.Flat;
            btnSil.Location = new Point(493, 129);
            btnSil.Name = "btnSil";
            btnSil.Size = new Size(148, 49);
            btnSil.TabIndex = 3;
            btnSil.Text = "SİL";
            btnSil.UseVisualStyleBackColor = true;
            btnSil.Click += btnSil_Click;
            // 
            // btnGuncelle
            // 
            btnGuncelle.BackColor = Color.Transparent;
            btnGuncelle.Cursor = Cursors.Hand;
            btnGuncelle.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnGuncelle.FlatStyle = FlatStyle.Flat;
            btnGuncelle.Location = new Point(349, 184);
            btnGuncelle.Name = "btnGuncelle";
            btnGuncelle.Size = new Size(292, 49);
            btnGuncelle.TabIndex = 4;
            btnGuncelle.Text = "GÜNCELLE";
            btnGuncelle.UseVisualStyleBackColor = false;
            btnGuncelle.Click += btnGuncelle_Click;
            // 
            // btnCikis
            // 
            btnCikis.Cursor = Cursors.Hand;
            btnCikis.FlatStyle = FlatStyle.Flat;
            btnCikis.Location = new Point(349, 239);
            btnCikis.Name = "btnCikis";
            btnCikis.Size = new Size(292, 44);
            btnCikis.TabIndex = 6;
            btnCikis.Text = "Çıkış Yap";
            btnCikis.UseVisualStyleBackColor = true;
            btnCikis.Click += btnCikis_Click_1;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Items.AddRange(new object[] { "C#", "İngilizce", "Html", "Css", "bla bla", "C#", "İngilizce", "Html", "Css", "bla bla" });
            listBox1.Location = new Point(11, 45);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(328, 238);
            listBox1.TabIndex = 5;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblYap
            // 
            lblYap.AutoSize = true;
            lblYap.BackColor = Color.Transparent;
            lblYap.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            lblYap.Location = new Point(69, 9);
            lblYap.Name = "lblYap";
            lblYap.Size = new Size(225, 33);
            lblYap.TabIndex = 15;
            lblYap.Text = "ÖĞRENECEKLERİM";
            // 
            // Form1
            // 
            AcceptButton = btnEkle;
            AutoScaleDimensions = new SizeF(11F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            CancelButton = btnCikis;
            ClientSize = new Size(672, 294);
            Controls.Add(listBox1);
            Controls.Add(lblYap);
            Controls.Add(txtNote);
            Controls.Add(label1);
            Controls.Add(btnEkle);
            Controls.Add(btnSil);
            Controls.Add(btnCikis);
            Controls.Add(btnGuncelle);
            Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            KeyPreview = true;
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MdiChildrenMinimizedAnchorBottom = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Öğrenmem Gerekenler";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private RichTextBox txtNote;
        private Label label1;
        private Button btnEkle;
        private Button btnSil;
        private Button btnGuncelle;
        private Button btnCikis;
        private CheckedListBox listBox1;
        private Label lblYap;
    }
}