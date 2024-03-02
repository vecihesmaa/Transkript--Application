namespace degisikdeneme
{
    partial class SilDersKodu
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
            this.txtSilDersKodu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtSilDersKodu
            // 
            this.txtSilDersKodu.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSilDersKodu.Location = new System.Drawing.Point(265, 167);
            this.txtSilDersKodu.Name = "txtSilDersKodu";
            this.txtSilDersKodu.Size = new System.Drawing.Size(211, 34);
            this.txtSilDersKodu.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(126, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 27);
            this.label1.TabIndex = 4;
            this.label1.Text = "DersKodu";
            // 
            // btnGir
            // 
            this.btnGir.BackColor = System.Drawing.Color.CadetBlue;
            this.btnGir.Font = new System.Drawing.Font("Georgia", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGir.Location = new System.Drawing.Point(265, 251);
            this.btnGir.Name = "btnGir";
            this.btnGir.Size = new System.Drawing.Size(198, 58);
            this.btnGir.TabIndex = 3;
            this.btnGir.Text = "Gir";
            this.btnGir.UseVisualStyleBackColor = false;
            this.btnGir.Click += new System.EventHandler(this.btnGir_Click);
            // 
            // SilDersKodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSilDersKodu);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGir);
            this.Name = "SilDersKodu";
            this.Text = "SilDersKodu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSilDersKodu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGir;
    }
}