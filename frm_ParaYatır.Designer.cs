namespace BankaOtomasyonu
{
    partial class frm_ParaYatır
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
            this.btn_ParaYatir = new System.Windows.Forms.Button();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.lbl_Tc = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.cmbara = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.cmbmusteritc = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_ParaYatir
            // 
            this.btn_ParaYatir.Location = new System.Drawing.Point(96, 235);
            this.btn_ParaYatir.Name = "btn_ParaYatir";
            this.btn_ParaYatir.Size = new System.Drawing.Size(75, 23);
            this.btn_ParaYatir.TabIndex = 77;
            this.btn_ParaYatir.Text = "Para Yatır";
            this.btn_ParaYatir.UseVisualStyleBackColor = true;
            this.btn_ParaYatir.Click += new System.EventHandler(this.btn_ParaYatir_Click);
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(133, 190);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(100, 20);
            this.txt_tutar.TabIndex = 76;
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(129, 150);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(25, 13);
            this.lbl_bakiye.TabIndex = 72;
            this.lbl_bakiye.Text = "------";
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.AutoSize = true;
            this.lbl_Tc.Location = new System.Drawing.Point(129, 128);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(25, 13);
            this.lbl_Tc.TabIndex = 73;
            this.lbl_Tc.Text = "------";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 74;
            this.label1.Text = "Çekilecek Tutar";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(129, 106);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(25, 13);
            this.lbl_soyad.TabIndex = 75;
            this.lbl_soyad.Text = "------";
            // 
            // cmbara
            // 
            this.cmbara.FormattingEnabled = true;
            this.cmbara.Location = new System.Drawing.Point(116, 49);
            this.cmbara.Name = "cmbara";
            this.cmbara.Size = new System.Drawing.Size(121, 21);
            this.cmbara.TabIndex = 71;
            this.cmbara.SelectedIndexChanged += new System.EventHandler(this.cmbara_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 52);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Hesap No";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(129, 83);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(25, 13);
            this.lbl_ad.TabIndex = 78;
            this.lbl_ad.Text = "------";
            // 
            // cmbmusteritc
            // 
            this.cmbmusteritc.FormattingEnabled = true;
            this.cmbmusteritc.Location = new System.Drawing.Point(116, 18);
            this.cmbmusteritc.Name = "cmbmusteritc";
            this.cmbmusteritc.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteritc.TabIndex = 83;
            this.cmbmusteritc.SelectedIndexChanged += new System.EventHandler(this.cmbmusteritc_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 82;
            this.label3.Text = "Müşteri Tc";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(81, 150);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 13);
            this.label5.TabIndex = 91;
            this.label5.Text = "Bakiye";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(80, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(20, 13);
            this.label6.TabIndex = 92;
            this.label6.Text = "Tc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(80, 106);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 93;
            this.label7.Text = "Soyad";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(80, 83);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "Ad";
            // 
            // frm_ParaYatır
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 276);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cmbmusteritc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.btn_ParaYatir);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.lbl_Tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.cmbara);
            this.Controls.Add(this.label4);
            this.Name = "frm_ParaYatır";
            this.Text = "frm_ParaYatır";
            this.Load += new System.EventHandler(this.frm_ParaYatır_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ParaYatir;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label lbl_Tc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.ComboBox cmbara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.ComboBox cmbmusteritc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}