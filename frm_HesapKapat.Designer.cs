namespace BankaOtomasyonu
{
    partial class frm_HesapKapat
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
            this.cmbara = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.lbl_Tc = new System.Windows.Forms.Label();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.btn_hesapkapat = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbmusteritc = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbara
            // 
            this.cmbara.FormattingEnabled = true;
            this.cmbara.Location = new System.Drawing.Point(97, 48);
            this.cmbara.Name = "cmbara";
            this.cmbara.Size = new System.Drawing.Size(121, 21);
            this.cmbara.TabIndex = 59;
            this.cmbara.SelectedIndexChanged += new System.EventHandler(this.cmbara_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 51);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 58;
            this.label4.Text = "Hesap No: ";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(133, 119);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(31, 13);
            this.lbl_soyad.TabIndex = 63;
            this.lbl_soyad.Text = "--------";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(133, 98);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(31, 13);
            this.lbl_ad.TabIndex = 62;
            this.lbl_ad.Text = "--------";
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.AutoSize = true;
            this.lbl_Tc.Location = new System.Drawing.Point(133, 140);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(31, 13);
            this.lbl_Tc.TabIndex = 63;
            this.lbl_Tc.Text = "--------";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(133, 163);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(31, 13);
            this.lbl_bakiye.TabIndex = 63;
            this.lbl_bakiye.Text = "--------";
            // 
            // btn_hesapkapat
            // 
            this.btn_hesapkapat.Location = new System.Drawing.Point(87, 197);
            this.btn_hesapkapat.Name = "btn_hesapkapat";
            this.btn_hesapkapat.Size = new System.Drawing.Size(92, 23);
            this.btn_hesapkapat.TabIndex = 64;
            this.btn_hesapkapat.Text = "Hesap Kapat";
            this.btn_hesapkapat.UseVisualStyleBackColor = true;
            this.btn_hesapkapat.Click += new System.EventHandler(this.btn_hesapkapat_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(67, 140);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "TCKN:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(67, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "Soyadı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(67, 98);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 76;
            this.label7.Text = "Adı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 163);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Bakiye:";
            // 
            // cmbmusteritc
            // 
            this.cmbmusteritc.FormattingEnabled = true;
            this.cmbmusteritc.Location = new System.Drawing.Point(97, 21);
            this.cmbmusteritc.Name = "cmbmusteritc";
            this.cmbmusteritc.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteritc.TabIndex = 79;
            this.cmbmusteritc.SelectedIndexChanged += new System.EventHandler(this.cmbmusteritc_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 24);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 78;
            this.label1.Text = "Müşteri Tc";
            // 
            // frm_HesapKapat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 242);
            this.Controls.Add(this.cmbmusteritc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_hesapkapat);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.lbl_Tc);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.cmbara);
            this.Controls.Add(this.label4);
            this.Name = "frm_HesapKapat";
            this.Text = "frm_HesapKapat";
            this.Load += new System.EventHandler(this.frm_HesapKapat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label lbl_Tc;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Button btn_hesapkapat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbmusteritc;
        private System.Windows.Forms.Label label1;
    }
}