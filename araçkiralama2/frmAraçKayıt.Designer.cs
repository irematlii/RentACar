
namespace araçkiralama2
{
    partial class frmAraçKayıt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçKayıt));
            Plakatxt = new System.Windows.Forms.TextBox();
            Markacombo = new System.Windows.Forms.ComboBox();
            Yiltxt = new System.Windows.Forms.TextBox();
            Kmtxt = new System.Windows.Forms.TextBox();
            Ücrettxt = new System.Windows.Forms.TextBox();
            Yakıtcombo = new System.Windows.Forms.ComboBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            Renkcombo = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new System.Drawing.Point(137, 46);
            Plakatxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new System.Drawing.Size(229, 23);
            Plakatxt.TabIndex = 0;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "opel", "reanult", "fiat", "ford" });
            Markacombo.Location = new System.Drawing.Point(137, 80);
            Markacombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new System.Drawing.Size(229, 23);
            Markacombo.TabIndex = 1;
            Markacombo.SelectedIndexChanged += Markacombo_SelectedIndexChanged;
            // 
            // Yiltxt
            // 
            Yiltxt.Location = new System.Drawing.Point(137, 119);
            Yiltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new System.Drawing.Size(229, 23);
            Yiltxt.TabIndex = 3;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new System.Drawing.Point(137, 185);
            Kmtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new System.Drawing.Size(229, 23);
            Kmtxt.TabIndex = 5;
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new System.Drawing.Point(137, 252);
            Ücrettxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new System.Drawing.Size(229, 23);
            Ücrettxt.TabIndex = 6;
            // 
            // Yakıtcombo
            // 
            Yakıtcombo.FormattingEnabled = true;
            Yakıtcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg", "Elektrik (hibrit)" });
            Yakıtcombo.Location = new System.Drawing.Point(137, 218);
            Yakıtcombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Yakıtcombo.Name = "Yakıtcombo";
            Yakıtcombo.Size = new System.Drawing.Size(229, 23);
            Yakıtcombo.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Maroon;
            label1.Location = new System.Drawing.Point(66, 50);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 21);
            label1.TabIndex = 8;
            label1.Text = "Plaka";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Maroon;
            label2.Location = new System.Drawing.Point(61, 83);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 21);
            label2.TabIndex = 9;
            label2.Text = "Marka";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Maroon;
            label4.Location = new System.Drawing.Point(37, 121);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 21);
            label4.TabIndex = 11;
            label4.Text = "Model(Yıl)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Maroon;
            label5.Location = new System.Drawing.Point(69, 154);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(44, 21);
            label5.TabIndex = 12;
            label5.Text = "Renk";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Maroon;
            label6.Location = new System.Drawing.Point(78, 187);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 21);
            label6.TabIndex = 13;
            label6.Text = "Km";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Maroon;
            label7.Location = new System.Drawing.Point(70, 220);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 21);
            label7.TabIndex = 14;
            label7.Text = "Yakıt";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Maroon;
            label8.Location = new System.Drawing.Point(37, 253);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 21);
            label8.TabIndex = 15;
            label8.Text = "Kira Ücreti";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.ImageKey = "ekleees.png";
            button1.Location = new System.Drawing.Point(137, 304);
            button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(105, 73);
            button1.TabIndex = 17;
            button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = System.Drawing.Color.White;
            button2.BackgroundImage = (System.Drawing.Image)resources.GetObject("button2.BackgroundImage");
            button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button2.ImageKey = "iptal2.png";
            button2.Location = new System.Drawing.Point(262, 304);
            button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(104, 73);
            button2.TabIndex = 18;
            button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // Renkcombo
            // 
            Renkcombo.FormattingEnabled = true;
            Renkcombo.Items.AddRange(new object[] { "Beyaz", "Gri", "Siyah", "Kırmızı", "Mavi", "Kahverengi", "Sarı", "Yeşil", "Turuncu", "Pembe" });
            Renkcombo.Location = new System.Drawing.Point(137, 150);
            Renkcombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Renkcombo.Name = "Renkcombo";
            Renkcombo.Size = new System.Drawing.Size(229, 23);
            Renkcombo.TabIndex = 21;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(167, 363);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(43, 14);
            label3.TabIndex = 22;
            label3.Text = "KAYIT";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.ForeColor = System.Drawing.Color.Black;
            label9.Location = new System.Drawing.Point(297, 363);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(43, 14);
            label9.TabIndex = 22;
            label9.Text = "İPTAL";
            // 
            // frmAraçKayıt
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(480, 421);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(Renkcombo);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Yakıtcombo);
            Controls.Add(Ücrettxt);
            Controls.Add(Kmtxt);
            Controls.Add(Yiltxt);
            Controls.Add(Markacombo);
            Controls.Add(Plakatxt);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmAraçKayıt";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Araç Kayıt Sayfası";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.ComboBox Renkcombo;
        private System.Windows.Forms.TextBox Kmtxt;

        private System.Windows.Forms.ComboBox Yakıtcombo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
    }
}