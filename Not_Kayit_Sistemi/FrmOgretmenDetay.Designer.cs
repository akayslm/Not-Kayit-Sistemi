namespace Not_Kayit_Sistemi
{
    partial class FrmOgretmenDetay
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
            groupBox1 = new GroupBox();
            label1 = new Label();
            maskedTextBox1 = new MaskedTextBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            groupBox2 = new GroupBox();
            button2 = new Button();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label6 = new Label();
            textBox5 = new TextBox();
            groupBox3 = new GroupBox();
            label9 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox4 = new GroupBox();
            dataGridView1 = new DataGridView();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(maskedTextBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(284, 230);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Öğrenci Ekle";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 52);
            label1.Name = "label1";
            label1.Size = new Size(89, 24);
            label1.TabIndex = 0;
            label1.Text = "Numara:";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(117, 52);
            maskedTextBox1.Mask = "0000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(161, 30);
            maskedTextBox1.TabIndex = 1;
            maskedTextBox1.ValidatingType = typeof(int);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(117, 88);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(161, 30);
            textBox1.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 94);
            label2.Name = "label2";
            label2.Size = new Size(40, 24);
            label2.TabIndex = 0;
            label2.Text = "Ad:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(42, 127);
            label3.Name = "label3";
            label3.Size = new Size(69, 24);
            label3.TabIndex = 0;
            label3.Text = "Soyad:";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(117, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(161, 30);
            textBox2.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(117, 176);
            button1.Name = "button1";
            button1.Size = new Size(161, 34);
            button1.TabIndex = 3;
            button1.Text = "Öğrenci Kaydet";
            button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(textBox5);
            groupBox2.Controls.Add(textBox3);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(textBox4);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(label5);
            groupBox2.Location = new Point(302, 12);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(284, 230);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Sınav Notları";
            // 
            // button2
            // 
            button2.Location = new Point(117, 176);
            button2.Name = "button2";
            button2.Size = new Size(161, 34);
            button2.TabIndex = 3;
            button2.Text = "Güncelle";
            button2.UseVisualStyleBackColor = true;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(117, 88);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(161, 30);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(117, 52);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(161, 30);
            textBox4.TabIndex = 2;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(18, 55);
            label5.Name = "label5";
            label5.Size = new Size(79, 24);
            label5.TabIndex = 0;
            label5.Text = "Sınav 1:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(18, 91);
            label4.Name = "label4";
            label4.Size = new Size(81, 24);
            label4.TabIndex = 0;
            label4.Text = "Sınav 2:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(18, 127);
            label6.Name = "label6";
            label6.Size = new Size(81, 24);
            label6.TabIndex = 0;
            label6.Text = "Sınav 3:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(117, 124);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 30);
            textBox5.TabIndex = 2;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label8);
            groupBox3.Controls.Add(label12);
            groupBox3.Controls.Add(label11);
            groupBox3.Controls.Add(label10);
            groupBox3.Controls.Add(label7);
            groupBox3.Controls.Add(label9);
            groupBox3.Location = new Point(595, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(284, 230);
            groupBox3.TabIndex = 0;
            groupBox3.TabStop = false;
            groupBox3.Text = "Sınav Notları";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(43, 55);
            label9.Name = "label9";
            label9.Size = new Size(100, 24);
            label9.TabIndex = 0;
            label9.Text = "Ortalama:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 94);
            label7.Name = "label7";
            label7.Size = new Size(129, 24);
            label7.TabIndex = 0;
            label7.Text = "Geçen Sayısı:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(18, 132);
            label8.Name = "label8";
            label8.Size = new Size(125, 24);
            label8.TabIndex = 0;
            label8.Text = "Kalan Sayısı:";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(149, 55);
            label10.Name = "label10";
            label10.Size = new Size(34, 24);
            label10.TabIndex = 0;
            label10.Text = "00";
            label10.Click += label10_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(149, 94);
            label11.Name = "label11";
            label11.Size = new Size(34, 24);
            label11.TabIndex = 0;
            label11.Text = "00";
            label11.Click += label10_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(149, 132);
            label12.Name = "label12";
            label12.Size = new Size(34, 24);
            label12.TabIndex = 0;
            label12.Text = "00";
            label12.Click += label10_Click;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(dataGridView1);
            groupBox4.Location = new Point(12, 258);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(867, 230);
            groupBox4.TabIndex = 0;
            groupBox4.TabStop = false;
            groupBox4.Text = "Sınav Notları";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(861, 201);
            dataGridView1.TabIndex = 0;
            // 
            // FrmOgretmenDetay
            // 
            AutoScaleDimensions = new SizeF(12F, 24F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(192, 192, 0);
            ClientSize = new Size(891, 500);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Font = new Font("Georgia", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4, 4, 4, 4);
            Name = "FrmOgretmenDetay";
            Text = "FrmOgretmenDetay";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private MaskedTextBox maskedTextBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private Label label3;
        private Label label2;
        private GroupBox groupBox2;
        private Button button2;
        private TextBox textBox5;
        private TextBox textBox3;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private Label label5;
        private GroupBox groupBox3;
        private Label label8;
        private Label label10;
        private Label label7;
        private Label label9;
        private Label label12;
        private Label label11;
        private GroupBox groupBox4;
        private DataGridView dataGridView1;
    }
}