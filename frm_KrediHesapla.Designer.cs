namespace BankaOtomasyonu
{
    partial class frm_KrediHesapla
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
            this.btn_hesapla = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKrediTutari = new System.Windows.Forms.TextBox();
            this.txtKrediVadeSuresi = new System.Windows.Forms.TextBox();
            this.cmb_KrediTuru = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_hesapla
            // 
            this.btn_hesapla.Location = new System.Drawing.Point(137, 156);
            this.btn_hesapla.Name = "btn_hesapla";
            this.btn_hesapla.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapla.TabIndex = 0;
            this.btn_hesapla.Text = "Hesapla";
            this.btn_hesapla.UseVisualStyleBackColor = true;
            this.btn_hesapla.Click += new System.EventHandler(this.btn_hesapla_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kredi Tutarı (TL)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Kredi Vade Süresi (Ay)";
            // 
            // txtKrediTutari
            // 
            this.txtKrediTutari.Location = new System.Drawing.Point(170, 71);
            this.txtKrediTutari.Name = "txtKrediTutari";
            this.txtKrediTutari.Size = new System.Drawing.Size(121, 20);
            this.txtKrediTutari.TabIndex = 3;
            // 
            // txtKrediVadeSuresi
            // 
            this.txtKrediVadeSuresi.Location = new System.Drawing.Point(170, 106);
            this.txtKrediVadeSuresi.Name = "txtKrediVadeSuresi";
            this.txtKrediVadeSuresi.Size = new System.Drawing.Size(121, 20);
            this.txtKrediVadeSuresi.TabIndex = 4;
            // 
            // cmb_KrediTuru
            // 
            this.cmb_KrediTuru.FormattingEnabled = true;
            this.cmb_KrediTuru.Location = new System.Drawing.Point(170, 30);
            this.cmb_KrediTuru.Name = "cmb_KrediTuru";
            this.cmb_KrediTuru.Size = new System.Drawing.Size(121, 21);
            this.cmb_KrediTuru.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Kredi Türünü Hesapla";
            // 
            // frm_KrediHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 224);
            this.Controls.Add(this.cmb_KrediTuru);
            this.Controls.Add(this.txtKrediVadeSuresi);
            this.Controls.Add(this.txtKrediTutari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_hesapla);
            this.Name = "frm_KrediHesapla";
            this.Text = "frm_KrediHesapla";
            this.Load += new System.EventHandler(this.frm_KrediHesapla_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_hesapla;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKrediTutari;
        private System.Windows.Forms.TextBox txtKrediVadeSuresi;
        private System.Windows.Forms.ComboBox cmb_KrediTuru;
        private System.Windows.Forms.Label label3;
    }
}