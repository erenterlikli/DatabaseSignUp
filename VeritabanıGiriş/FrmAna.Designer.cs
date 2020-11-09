namespace VeritabanıGiriş
{
    partial class FrmAna
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
            this.txtSifDeg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(169, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldiniz!\r\n";
            // 
            // txtSifDeg
            // 
            this.txtSifDeg.Font = new System.Drawing.Font("Meiryo", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(162)));
            this.txtSifDeg.Location = new System.Drawing.Point(161, 179);
            this.txtSifDeg.Name = "txtSifDeg";
            this.txtSifDeg.Size = new System.Drawing.Size(171, 43);
            this.txtSifDeg.TabIndex = 5;
            this.txtSifDeg.Text = "Şifre Değiştir";
            this.txtSifDeg.UseVisualStyleBackColor = true;
            this.txtSifDeg.Click += new System.EventHandler(this.txtSifDeg_Click);
            // 
            // FrmAna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.ClientSize = new System.Drawing.Size(496, 406);
            this.Controls.Add(this.txtSifDeg);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmAna";
            this.Text = "Ana Sayfa";
            this.Load += new System.EventHandler(this.FrmAna_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button txtSifDeg;
    }
}