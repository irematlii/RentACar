
namespace araçkiralama2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            button1 = new System.Windows.Forms.Button();
            dtpDonusTarihi = new System.Windows.Forms.DateTimePicker();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            lblToplamTutar = new System.Windows.Forms.Label();
            label5 = new System.Windows.Forms.Label();
            cmbMusteri = new System.Windows.Forms.ComboBox();
            cmbAraba = new System.Windows.Forms.ComboBox();
            lblGunSayisi = new System.Windows.Forms.Label();
            label15 = new System.Windows.Forms.Label();
            label6 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(172, 44);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(48, 24);
            label1.TabIndex = 1;
            label1.Text = "TC :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(142, 96);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(78, 24);
            label2.TabIndex = 3;
            label2.Text = "Plaka :";
            // 
            // button1
            // 
            button1.BackColor = System.Drawing.Color.White;
            button1.BackgroundImage = (System.Drawing.Image)resources.GetObject("button1.BackgroundImage");
            button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            button1.ForeColor = System.Drawing.Color.White;
            button1.Location = new System.Drawing.Point(415, 227);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(148, 68);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // dtpDonusTarihi
            // 
            dtpDonusTarihi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dtpDonusTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            dtpDonusTarihi.Location = new System.Drawing.Point(226, 154);
            dtpDonusTarihi.Name = "dtpDonusTarihi";
            dtpDonusTarihi.Size = new System.Drawing.Size(362, 34);
            dtpDonusTarihi.TabIndex = 6;
            dtpDonusTarihi.ValueChanged += dtpDonusTarihi_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(74, 159);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(150, 24);
            label3.TabIndex = 7;
            label3.Text = "Dönüş Tarihi :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label4.Location = new System.Drawing.Point(61, 271);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(163, 24);
            label4.TabIndex = 8;
            label4.Text = "Toplam Tutar : ";
            // 
            // lblToplamTutar
            // 
            lblToplamTutar.AutoSize = true;
            lblToplamTutar.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblToplamTutar.Location = new System.Drawing.Point(230, 268);
            lblToplamTutar.Name = "lblToplamTutar";
            lblToplamTutar.Size = new System.Drawing.Size(23, 28);
            lblToplamTutar.TabIndex = 9;
            lblToplamTutar.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            label5.Location = new System.Drawing.Point(311, 267);
            label5.Name = "label5";
            label5.Size = new System.Drawing.Size(23, 28);
            label5.TabIndex = 10;
            label5.Text = "₺";
            // 
            // cmbMusteri
            // 
            cmbMusteri.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbMusteri.FormattingEnabled = true;
            cmbMusteri.Location = new System.Drawing.Point(226, 32);
            cmbMusteri.Name = "cmbMusteri";
            cmbMusteri.Size = new System.Drawing.Size(362, 36);
            cmbMusteri.TabIndex = 13;
            // 
            // cmbAraba
            // 
            cmbAraba.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            cmbAraba.FormattingEnabled = true;
            cmbAraba.Location = new System.Drawing.Point(226, 90);
            cmbAraba.Name = "cmbAraba";
            cmbAraba.Size = new System.Drawing.Size(362, 36);
            cmbAraba.TabIndex = 14;
            // 
            // lblGunSayisi
            // 
            lblGunSayisi.AutoSize = true;
            lblGunSayisi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            lblGunSayisi.Location = new System.Drawing.Point(226, 213);
            lblGunSayisi.Name = "lblGunSayisi";
            lblGunSayisi.Size = new System.Drawing.Size(23, 28);
            lblGunSayisi.TabIndex = 16;
            lblGunSayisi.Text = "0";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label15.Location = new System.Drawing.Point(159, 217);
            label15.Name = "label15";
            label15.Size = new System.Drawing.Size(61, 23);
            label15.TabIndex = 15;
            label15.Text = "Gün :";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label6.Location = new System.Drawing.Point(460, 298);
            label6.Name = "label6";
            label6.Size = new System.Drawing.Size(56, 16);
            label6.TabIndex = 17;
            label6.Text = "KİRALA";
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(700, 340);
            Controls.Add(label6);
            Controls.Add(lblGunSayisi);
            Controls.Add(label15);
            Controls.Add(cmbAraba);
            Controls.Add(cmbMusteri);
            Controls.Add(label5);
            Controls.Add(lblToplamTutar);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpDonusTarihi);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dtpDonusTarihi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMusteri;
        private System.Windows.Forms.ComboBox cmbAraba;
        private System.Windows.Forms.Label lblGunSayisi;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label6;
    }
}