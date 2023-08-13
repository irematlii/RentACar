
namespace araçkiralama2
{
    partial class frmAraçListele
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAraçListele));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            ımageList1 = new System.Windows.Forms.ImageList(components);
            btnİptal = new System.Windows.Forms.Button();
            btnGüncelle = new System.Windows.Forms.Button();
            label8 = new System.Windows.Forms.Label();
            label7 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            Yakıtcombo = new System.Windows.Forms.ComboBox();
            Ücrettxt = new System.Windows.Forms.TextBox();
            Kmtxt = new System.Windows.Forms.TextBox();
            Renktxt = new System.Windows.Forms.TextBox();
            Yiltxt = new System.Windows.Forms.TextBox();
            Markacombo = new System.Windows.Forms.ComboBox();
            Plakatxt = new System.Windows.Forms.TextBox();
            btnSil = new System.Windows.Forms.Button();
            openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            button1 = new System.Windows.Forms.Button();
            label3 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            label10 = new System.Windows.Forms.Label();
            label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(372, 11);
            dataGridView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(963, 293);
            dataGridView1.TabIndex = 0;
            dataGridView1.MouseDoubleClick += dataGridView1_MouseDoubleClick;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            ımageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            ımageList1.Images.SetKeyName(0, "featured-content-backup-ios-icon_2x.png");
            ımageList1.Images.SetKeyName(1, "unnamed.png");
            ımageList1.Images.SetKeyName(2, "iptal2.png");
            ımageList1.Images.SetKeyName(3, "güncelle.png");
            // 
            // btnİptal
            // 
            btnİptal.BackColor = System.Drawing.Color.White;
            btnİptal.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnİptal.BackgroundImage");
            btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnİptal.ImageKey = "(none)";
            btnİptal.Location = new System.Drawing.Point(524, 333);
            btnİptal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new System.Drawing.Size(143, 76);
            btnİptal.TabIndex = 38;
            btnİptal.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnİptal.UseVisualStyleBackColor = false;
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = System.Drawing.Color.White;
            btnGüncelle.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGüncelle.BackgroundImage");
            btnGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGüncelle.ImageKey = "güncelle.png";
            btnGüncelle.Location = new System.Drawing.Point(62, 330);
            btnGüncelle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new System.Drawing.Size(154, 79);
            btnGüncelle.TabIndex = 37;
            btnGüncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.ForeColor = System.Drawing.Color.Black;
            label8.Location = new System.Drawing.Point(62, 269);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(90, 21);
            label8.TabIndex = 35;
            label8.Text = "Kira Ücreti";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.ForeColor = System.Drawing.Color.Black;
            label7.Location = new System.Drawing.Point(62, 227);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(47, 21);
            label7.TabIndex = 34;
            label7.Text = "Yakıt";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(62, 187);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(31, 21);
            label6.TabIndex = 33;
            label6.Text = "Km";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(62, 148);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(44, 21);
            label5.TabIndex = 32;
            label5.Text = "Renk";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(62, 98);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(82, 21);
            label4.TabIndex = 31;
            label4.Text = "Model(Yıl)";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(62, 59);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(54, 21);
            label2.TabIndex = 29;
            label2.Text = "Marka";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = System.Drawing.Color.Transparent;
            label1.Font = new System.Drawing.Font("Comic Sans MS", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(62, 11);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(46, 21);
            label1.TabIndex = 28;
            label1.Text = "Plaka";
            // 
            // Yakıtcombo
            // 
            Yakıtcombo.FormattingEnabled = true;
            Yakıtcombo.Items.AddRange(new object[] { "Dizel", "Benzin", "Benzin+Lpg" });
            Yakıtcombo.Location = new System.Drawing.Point(189, 227);
            Yakıtcombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Yakıtcombo.Name = "Yakıtcombo";
            Yakıtcombo.Size = new System.Drawing.Size(157, 23);
            Yakıtcombo.TabIndex = 27;
            // 
            // Ücrettxt
            // 
            Ücrettxt.Location = new System.Drawing.Point(189, 269);
            Ücrettxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Ücrettxt.Name = "Ücrettxt";
            Ücrettxt.Size = new System.Drawing.Size(157, 23);
            Ücrettxt.TabIndex = 26;
            // 
            // Kmtxt
            // 
            Kmtxt.Location = new System.Drawing.Point(189, 185);
            Kmtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Kmtxt.Name = "Kmtxt";
            Kmtxt.Size = new System.Drawing.Size(157, 23);
            Kmtxt.TabIndex = 25;
            // 
            // Renktxt
            // 
            Renktxt.Location = new System.Drawing.Point(189, 146);
            Renktxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Renktxt.Name = "Renktxt";
            Renktxt.Size = new System.Drawing.Size(157, 23);
            Renktxt.TabIndex = 24;
            // 
            // Yiltxt
            // 
            Yiltxt.Location = new System.Drawing.Point(189, 102);
            Yiltxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Yiltxt.Name = "Yiltxt";
            Yiltxt.Size = new System.Drawing.Size(157, 23);
            Yiltxt.TabIndex = 23;
            // 
            // Markacombo
            // 
            Markacombo.FormattingEnabled = true;
            Markacombo.Items.AddRange(new object[] { "opel", "reanult", "fiat", "ford" });
            Markacombo.Location = new System.Drawing.Point(189, 59);
            Markacombo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Markacombo.Name = "Markacombo";
            Markacombo.Size = new System.Drawing.Size(157, 23);
            Markacombo.TabIndex = 21;
            // 
            // Plakatxt
            // 
            Plakatxt.Location = new System.Drawing.Point(189, 11);
            Plakatxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Plakatxt.Name = "Plakatxt";
            Plakatxt.Size = new System.Drawing.Size(157, 23);
            Plakatxt.TabIndex = 20;
            // 
            // btnSil
            // 
            btnSil.BackColor = System.Drawing.Color.White;
            btnSil.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSil.ImageKey = "unnamed.png";
            btnSil.Location = new System.Drawing.Point(302, 330);
            btnSil.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(143, 76);
            btnSil.TabIndex = 40;
            btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.GhostWhite;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Location = new System.Drawing.Point(759, 330);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(143, 79);
            button1.TabIndex = 42;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(97, 420);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(94, 19);
            label3.TabIndex = 43;
            label3.Text = "GÜNCELLE";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label9.Location = new System.Drawing.Point(352, 419);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(35, 19);
            label9.TabIndex = 43;
            label9.Text = "SİL";
            label9.Click += label9_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label10.Location = new System.Drawing.Point(555, 419);
            label10.Name = "label10";
            label10.Size = new System.Drawing.Size(59, 19);
            label10.TabIndex = 43;
            label10.Text = "İPTAL";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label11.Location = new System.Drawing.Point(780, 420);
            label11.Name = "label11";
            label11.Size = new System.Drawing.Size(90, 18);
            label11.TabIndex = 43;
            label11.Text = "ANASAYFA";
            // 
            // frmAraçListele
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(1340, 642);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(btnSil);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
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
            Controls.Add(Renktxt);
            Controls.Add(Yiltxt);
            Controls.Add(Markacombo);
            Controls.Add(Plakatxt);
            Controls.Add(dataGridView1);
            Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            Name = "frmAraçListele";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Araç Listeleme Sayfası";
            Load += frmAraçListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Yakıtcombo;
        private System.Windows.Forms.TextBox Ücrettxt;
        private System.Windows.Forms.TextBox Kmtxt;
        private System.Windows.Forms.TextBox Renktxt;
        private System.Windows.Forms.TextBox Yiltxt;
        private System.Windows.Forms.ComboBox Markacombo;
        private System.Windows.Forms.TextBox Plakatxt;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}