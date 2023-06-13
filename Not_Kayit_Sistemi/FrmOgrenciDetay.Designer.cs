namespace Not_Kayit_Sistemi
{
    partial class FrmOgrenciDetay
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
            lblAdSoyad = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            lblSinav1 = new Label();
            lblSinav2 = new Label();
            lblSinav3 = new Label();
            label9 = new Label();
            lblNumara = new Label();
            lblOrtalama = new Label();
            label12 = new Label();
            label13 = new Label();
            lblDurum = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 18);
            label1.TabIndex = 0;
            label1.Text = "Ad Soyad:";
            // 
            // lblAdSoyad
            // 
            lblAdSoyad.AutoSize = true;
            lblAdSoyad.Location = new Point(116, 29);
            lblAdSoyad.Name = "lblAdSoyad";
            lblAdSoyad.Size = new Size(52, 18);
            lblAdSoyad.TabIndex = 0;
            lblAdSoyad.Text = "NULL";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 124);
            label3.Name = "label3";
            label3.Size = new Size(64, 18);
            label3.TabIndex = 0;
            label3.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 164);
            label4.Name = "label4";
            label4.Size = new Size(65, 18);
            label4.TabIndex = 0;
            label4.Text = "Sınav 2:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 207);
            label5.Name = "label5";
            label5.Size = new Size(65, 18);
            label5.TabIndex = 0;
            label5.Text = "Sınav 3:";
            // 
            // lblSinav1
            // 
            lblSinav1.AutoSize = true;
            lblSinav1.Location = new Point(106, 124);
            lblSinav1.Name = "lblSinav1";
            lblSinav1.Size = new Size(28, 18);
            lblSinav1.TabIndex = 0;
            lblSinav1.Text = "00";
            // 
            // lblSinav2
            // 
            lblSinav2.AutoSize = true;
            lblSinav2.Location = new Point(106, 164);
            lblSinav2.Name = "lblSinav2";
            lblSinav2.Size = new Size(28, 18);
            lblSinav2.TabIndex = 0;
            lblSinav2.Text = "00";
            // 
            // lblSinav3
            // 
            lblSinav3.AutoSize = true;
            lblSinav3.Location = new Point(106, 207);
            lblSinav3.Name = "lblSinav3";
            lblSinav3.Size = new Size(28, 18);
            lblSinav3.TabIndex = 0;
            lblSinav3.Text = "00";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 61);
            label9.Name = "label9";
            label9.Size = new Size(71, 18);
            label9.TabIndex = 0;
            label9.Text = "Numara:";
            // 
            // lblNumara
            // 
            lblNumara.AutoSize = true;
            lblNumara.Location = new Point(116, 61);
            lblNumara.Name = "lblNumara";
            lblNumara.Size = new Size(48, 18);
            lblNumara.TabIndex = 0;
            lblNumara.Text = "0000";
            // 
            // lblOrtalama
            // 
            lblOrtalama.AutoSize = true;
            lblOrtalama.Location = new Point(116, 285);
            lblOrtalama.Name = "lblOrtalama";
            lblOrtalama.Size = new Size(28, 18);
            lblOrtalama.TabIndex = 0;
            lblOrtalama.Text = "00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(10, 285);
            label12.Name = "label12";
            label12.Size = new Size(80, 18);
            label12.TabIndex = 0;
            label12.Text = "Ortalama:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(12, 322);
            label13.Name = "label13";
            label13.Size = new Size(63, 18);
            label13.TabIndex = 0;
            label13.Text = "Durum:";
            // 
            // lblDurum
            // 
            lblDurum.AutoSize = true;
            lblDurum.Location = new Point(116, 322);
            lblDurum.Name = "lblDurum";
            lblDurum.Size = new Size(52, 18);
            lblDurum.TabIndex = 0;
            lblDurum.Text = "NULL";
            // 
            // FrmOgrenciDetay
            // 
            AutoScaleDimensions = new SizeF(9F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(359, 390);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(lblOrtalama);
            Controls.Add(label3);
            Controls.Add(lblSinav3);
            Controls.Add(lblSinav2);
            Controls.Add(lblSinav1);
            Controls.Add(lblNumara);
            Controls.Add(label9);
            Controls.Add(lblDurum);
            Controls.Add(label13);
            Controls.Add(lblAdSoyad);
            Controls.Add(label1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            Name = "FrmOgrenciDetay";
            Text = "Öğrenci Not Kayıt Sistemi";
            Load += FrmOgrenciDetay_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label lblAdSoyad;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label lblSinav1;
        private Label lblSinav2;
        private Label lblSinav3;
        private Label label9;
        private Label lblNumara;
        private Label lblOrtalama;
        private Label label12;
        private Label label13;
        private Label lblDurum;
    }
}