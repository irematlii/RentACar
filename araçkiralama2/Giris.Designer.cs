namespace araçkiralama2
{
    partial class Giris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            label1 = new System.Windows.Forms.Label();
            txtKullaniciAdi = new System.Windows.Forms.TextBox();
            btnGiris = new System.Windows.Forms.Button();
            txtSifre = new System.Windows.Forms.TextBox();
            label2 = new System.Windows.Forms.Label();
            checkBox1 = new System.Windows.Forms.CheckBox();
            label3 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label1.Location = new System.Drawing.Point(45, 47);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(155, 24);
            label1.TabIndex = 0;
            label1.Text = "Kullanıcı Adı : ";
            // 
            // txtKullaniciAdi
            // 
            txtKullaniciAdi.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtKullaniciAdi.Location = new System.Drawing.Point(195, 41);
            txtKullaniciAdi.Name = "txtKullaniciAdi";
            txtKullaniciAdi.Size = new System.Drawing.Size(213, 34);
            txtKullaniciAdi.TabIndex = 1;
            // 
            // btnGiris
            // 
            btnGiris.BackgroundImage = (System.Drawing.Image)resources.GetObject("btnGiris.BackgroundImage");
            btnGiris.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            btnGiris.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            btnGiris.Location = new System.Drawing.Point(234, 204);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new System.Drawing.Size(111, 69);
            btnGiris.TabIndex = 3;
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // txtSifre
            // 
            txtSifre.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            txtSifre.Location = new System.Drawing.Point(195, 105);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new System.Drawing.Size(213, 34);
            txtSifre.TabIndex = 2;
            txtSifre.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Tahoma", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label2.Location = new System.Drawing.Point(110, 111);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(71, 24);
            label2.TabIndex = 8;
            label2.Text = "Şifre :";
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            checkBox1.Location = new System.Drawing.Point(197, 161);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new System.Drawing.Size(139, 23);
            checkBox1.TabIndex = 5;
            checkBox1.Text = "Şifreyi Göster";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = System.Drawing.Color.White;
            label3.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            label3.Location = new System.Drawing.Point(268, 259);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(42, 14);
            label3.TabIndex = 9;
            label3.Text = "GİRİŞ";
            // 
            // Giris
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            BackColor = System.Drawing.Color.FromArgb(192, 192, 255);
            ClientSize = new System.Drawing.Size(576, 367);
            Controls.Add(label3);
            Controls.Add(checkBox1);
            Controls.Add(txtSifre);
            Controls.Add(label2);
            Controls.Add(btnGiris);
            Controls.Add(txtKullaniciAdi);
            Controls.Add(label1);
            Name = "Giris";
            Text = "Giris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label3;
    }
}