
namespace araçkiralama2
{
    partial class frmMüşteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMüşteriListele));
            dataGridView1 = new System.Windows.Forms.DataGridView();
            btnİptal = new System.Windows.Forms.Button();
            ımageList1 = new System.Windows.Forms.ImageList(components);
            btnGüncelle = new System.Windows.Forms.Button();
            label5 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            label3 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            label1 = new System.Windows.Forms.Label();
            txtEmail = new System.Windows.Forms.TextBox();
            txtAdres = new System.Windows.Forms.TextBox();
            txtTelefon = new System.Windows.Forms.TextBox();
            txtAdSoyad = new System.Windows.Forms.TextBox();
            txtTc = new System.Windows.Forms.TextBox();
            btnSil = new System.Windows.Forms.Button();
            label6 = new System.Windows.Forms.Label();
            textBox1 = new System.Windows.Forms.TextBox();
            label7 = new System.Windows.Forms.Label();
            label8 = new System.Windows.Forms.Label();
            label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = System.Drawing.Color.White;
            dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new System.Drawing.Point(422, 40);
            dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new System.Drawing.Size(910, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellMouseDoubleClick += dataGridView1_CellMouseDoubleClick;
            // 
            // btnİptal
            // 
            btnİptal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnİptal.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnİptal.BackgroundImage");
            btnİptal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnİptal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnİptal.Location = new System.Drawing.Point(277, 378);
            btnİptal.Margin = new System.Windows.Forms.Padding(4);
            btnİptal.Name = "btnİptal";
            btnİptal.Size = new System.Drawing.Size(123, 78);
            btnİptal.TabIndex = 23;
            btnİptal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnİptal.UseVisualStyleBackColor = false;
            btnİptal.Click += btnİptal_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (System.Windows.Forms.ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            ımageList1.Images.SetKeyName(0, "sil.png");
            ımageList1.Images.SetKeyName(1, "güncelle.png");
            ımageList1.Images.SetKeyName(2, "iptal2.png");
            // 
            // btnGüncelle
            // 
            btnGüncelle.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            btnGüncelle.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGüncelle.BackgroundImage");
            btnGüncelle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGüncelle.ForeColor = System.Drawing.Color.Snow;
            btnGüncelle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnGüncelle.Location = new System.Drawing.Point(143, 378);
            btnGüncelle.Margin = new System.Windows.Forms.Padding(4);
            btnGüncelle.Name = "btnGüncelle";
            btnGüncelle.Size = new System.Drawing.Size(126, 78);
            btnGüncelle.TabIndex = 22;
            btnGüncelle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnGüncelle.UseVisualStyleBackColor = false;
            btnGüncelle.Click += btnGüncelle_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label5.ForeColor = System.Drawing.Color.Black;
            label5.Location = new System.Drawing.Point(15, 329);
            label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(49, 18);
            label5.TabIndex = 21;
            label5.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.ForeColor = System.Drawing.Color.Black;
            label4.Location = new System.Drawing.Point(15, 253);
            label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(51, 18);
            label4.TabIndex = 20;
            label4.Text = "Adres";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.ForeColor = System.Drawing.Color.Black;
            label3.Location = new System.Drawing.Point(15, 189);
            label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(64, 18);
            label3.TabIndex = 19;
            label3.Text = "Telefon";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.ForeColor = System.Drawing.Color.Black;
            label2.Location = new System.Drawing.Point(15, 119);
            label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(77, 18);
            label2.TabIndex = 18;
            label2.Text = "Ad Soyad";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.ForeColor = System.Drawing.Color.Black;
            label1.Location = new System.Drawing.Point(15, 49);
            label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(27, 18);
            label1.TabIndex = 17;
            label1.Text = "TC";
            // 
            // txtEmail
            // 
            txtEmail.Location = new System.Drawing.Point(120, 324);
            txtEmail.Margin = new System.Windows.Forms.Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new System.Drawing.Size(257, 26);
            txtEmail.TabIndex = 16;
            // 
            // txtAdres
            // 
            txtAdres.Location = new System.Drawing.Point(120, 250);
            txtAdres.Margin = new System.Windows.Forms.Padding(4);
            txtAdres.Name = "txtAdres";
            txtAdres.Size = new System.Drawing.Size(257, 26);
            txtAdres.TabIndex = 15;
            // 
            // txtTelefon
            // 
            txtTelefon.Location = new System.Drawing.Point(120, 176);
            txtTelefon.Margin = new System.Windows.Forms.Padding(4);
            txtTelefon.Name = "txtTelefon";
            txtTelefon.Size = new System.Drawing.Size(257, 26);
            txtTelefon.TabIndex = 14;
            // 
            // txtAdSoyad
            // 
            txtAdSoyad.Location = new System.Drawing.Point(120, 109);
            txtAdSoyad.Margin = new System.Windows.Forms.Padding(4);
            txtAdSoyad.Name = "txtAdSoyad";
            txtAdSoyad.Size = new System.Drawing.Size(257, 26);
            txtAdSoyad.TabIndex = 13;
            // 
            // txtTc
            // 
            txtTc.Location = new System.Drawing.Point(120, 40);
            txtTc.Margin = new System.Windows.Forms.Padding(4);
            txtTc.Name = "txtTc";
            txtTc.Size = new System.Drawing.Size(257, 26);
            txtTc.TabIndex = 12;
            // 
            // btnSil
            // 
            btnSil.BackColor = System.Drawing.SystemColors.ButtonFace;
            btnSil.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnSil.BackgroundImage");
            btnSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnSil.ForeColor = System.Drawing.Color.Transparent;
            btnSil.Location = new System.Drawing.Point(13, 378);
            btnSil.Margin = new System.Windows.Forms.Padding(4);
            btnSil.Name = "btnSil";
            btnSil.Size = new System.Drawing.Size(118, 78);
            btnSil.TabIndex = 24;
            btnSil.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnSil.UseVisualStyleBackColor = false;
            btnSil.Click += btnSil_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.ForeColor = System.Drawing.Color.Black;
            label6.Location = new System.Drawing.Point(569, 13);
            label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(57, 18);
            label6.TabIndex = 26;
            label6.Text = "TC Ara";
            // 
            // textBox1
            // 
            textBox1.Location = new System.Drawing.Point(659, 8);
            textBox1.Margin = new System.Windows.Forms.Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new System.Drawing.Size(345, 26);
            textBox1.TabIndex = 25;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = System.Drawing.Color.White;
            label7.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label7.Location = new System.Drawing.Point(174, 437);
            label7.Name = "label7";
            label7.Size = new System.Drawing.Size(67, 14);
            label7.TabIndex = 27;
            label7.Text = "GÜNCELLE";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = System.Drawing.Color.White;
            label8.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label8.Location = new System.Drawing.Point(318, 437);
            label8.Name = "label8";
            label8.Size = new System.Drawing.Size(43, 14);
            label8.TabIndex = 27;
            label8.Text = "İPTAL";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.BackColor = System.Drawing.Color.White;
            label9.ForeColor = System.Drawing.Color.IndianRed;
            label9.Location = new System.Drawing.Point(52, 434);
            label9.Name = "label9";
            label9.Size = new System.Drawing.Size(27, 19);
            label9.TabIndex = 28;
            label9.Text = "Sil";
            // 
            // frmMüşteriListele
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(1382, 583);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(btnSil);
            Controls.Add(btnİptal);
            Controls.Add(btnGüncelle);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtEmail);
            Controls.Add(txtAdres);
            Controls.Add(txtTelefon);
            Controls.Add(txtAdSoyad);
            Controls.Add(txtTc);
            Controls.Add(dataGridView1);
            Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            ForeColor = System.Drawing.Color.Maroon;
            Name = "frmMüşteriListele";
            StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            Text = "Müşteri Listeleme Sayfası";
            Load += frmMüşteriListele_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnİptal;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTc;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ImageList ımageList1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}