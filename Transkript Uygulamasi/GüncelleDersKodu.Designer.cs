namespace degisikdeneme
{
    partial class GüncelleDersKodu
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtGüncelleDersKodu = new System.Windows.Forms.TextBox();
            this.btnGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(141, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(260, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ders Kodunu Giriniz";
            // 
            // txtGüncelleDersKodu
            // 
            this.txtGüncelleDersKodu.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtGüncelleDersKodu.Location = new System.Drawing.Point(422, 173);
            this.txtGüncelleDersKodu.Name = "txtGüncelleDersKodu";
            this.txtGüncelleDersKodu.Size = new System.Drawing.Size(175, 34);
            this.txtGüncelleDersKodu.TabIndex = 1;
            // 
            // btnGir
            // 
            this.btnGir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGir.Font = new System.Drawing.Font("Georgia", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGir.Location = new System.Drawing.Point(233, 282);
            this.btnGir.Name = "btnGir";
            this.btnGir.Size = new System.Drawing.Size(288, 56);
            this.btnGir.TabIndex = 2;
            this.btnGir.Text = "Gir";
            this.btnGir.UseVisualStyleBackColor = false;
            this.btnGir.Click += new System.EventHandler(this.btnGir_Click);
            // 
            // GüncelleDersKodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnGir);
            this.Controls.Add(this.txtGüncelleDersKodu);
            this.Controls.Add(this.label1);
            this.Name = "GüncelleDersKodu";
            this.Text = "GüncelleDersKodu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGüncelleDersKodu;
        private System.Windows.Forms.Button btnGir;
    }
}