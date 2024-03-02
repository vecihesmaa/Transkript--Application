namespace degisikdeneme
{
    partial class Giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Giris));
            this.btnDersEkle = new System.Windows.Forms.Button();
            this.btnDersSil = new System.Windows.Forms.Button();
            this.btnTranskript = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDersEkle
            // 
            this.btnDersEkle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDersEkle.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDersEkle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersEkle.Location = new System.Drawing.Point(39, 253);
            this.btnDersEkle.Name = "btnDersEkle";
            this.btnDersEkle.Size = new System.Drawing.Size(185, 81);
            this.btnDersEkle.TabIndex = 0;
            this.btnDersEkle.Text = "Ders Ekle";
            this.btnDersEkle.UseVisualStyleBackColor = false;
            this.btnDersEkle.Click += new System.EventHandler(this.btnDersEkle_Click_1);
            // 
            // btnDersSil
            // 
            this.btnDersSil.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDersSil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDersSil.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDersSil.Location = new System.Drawing.Point(268, 253);
            this.btnDersSil.Name = "btnDersSil";
            this.btnDersSil.Size = new System.Drawing.Size(199, 81);
            this.btnDersSil.TabIndex = 1;
            this.btnDersSil.Text = "Ders Sil";
            this.btnDersSil.UseVisualStyleBackColor = false;
            this.btnDersSil.Click += new System.EventHandler(this.btnDersSil_Click);
            // 
            // btnTranskript
            // 
            this.btnTranskript.BackColor = System.Drawing.Color.CadetBlue;
            this.btnTranskript.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTranskript.Location = new System.Drawing.Point(200, 355);
            this.btnTranskript.Name = "btnTranskript";
            this.btnTranskript.Size = new System.Drawing.Size(348, 83);
            this.btnTranskript.TabIndex = 2;
            this.btnTranskript.Text = "Transkript";
            this.btnTranskript.UseVisualStyleBackColor = false;
            this.btnTranskript.Click += new System.EventHandler(this.btnTranskript_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGüncelle.Font = new System.Drawing.Font("Georgia", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGüncelle.Location = new System.Drawing.Point(522, 253);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(199, 81);
            this.btnGüncelle.TabIndex = 3;
            this.btnGüncelle.Text = "Ders Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = false;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(1, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(501, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "UBYS SİSTEMİNE HOŞGELDİNİZ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(18, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(522, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "Yapmak İstediğiniz İşlemi Aşağıdan Seçebilirsiniz";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(606, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 160);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // Giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnTranskript);
            this.Controls.Add(this.btnDersSil);
            this.Controls.Add(this.btnDersEkle);
            this.Font = new System.Drawing.Font("Georgia", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Giris";
            this.Text = "Giriş Sayfası";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDersEkle;
        private System.Windows.Forms.Button btnDersSil;
        private System.Windows.Forms.Button btnTranskript;
        private System.Windows.Forms.Button btnGüncelle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

