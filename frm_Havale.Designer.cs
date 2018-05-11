namespace BankaOtomasyonu
{
    partial class frm_Havale
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
            this.cmbGonderenHesap = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbAlanHesap = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_gonderenAd = new System.Windows.Forms.Label();
            this.lbl_gonderenSoyad = new System.Windows.Forms.Label();
            this.lbl_gonderenBakiye = new System.Windows.Forms.Label();
            this.lbl_alanBakiye = new System.Windows.Forms.Label();
            this.lbl_alanSoyad = new System.Windows.Forms.Label();
            this.lbl_alanAd = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txthavaleTutar = new System.Windows.Forms.TextBox();
            this.btnhavaleYap = new System.Windows.Forms.Button();
            this.cmbGonderenTC = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cmbAlanTC = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_musTipi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbGonderenHesap
            // 
            this.cmbGonderenHesap.FormattingEnabled = true;
            this.cmbGonderenHesap.Location = new System.Drawing.Point(104, 36);
            this.cmbGonderenHesap.Name = "cmbGonderenHesap";
            this.cmbGonderenHesap.Size = new System.Drawing.Size(121, 21);
            this.cmbGonderenHesap.TabIndex = 65;
            this.cmbGonderenHesap.SelectedIndexChanged += new System.EventHandler(this.cmbGonderenHesap_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 39);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 64;
            this.label4.Text = "Gönderen Hesap";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(279, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Bakiye";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(279, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 75;
            this.label3.Text = "Soyad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(279, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Ad";
            // 
            // cmbAlanHesap
            // 
            this.cmbAlanHesap.FormattingEnabled = true;
            this.cmbAlanHesap.Location = new System.Drawing.Point(353, 36);
            this.cmbAlanHesap.Name = "cmbAlanHesap";
            this.cmbAlanHesap.Size = new System.Drawing.Size(121, 21);
            this.cmbAlanHesap.TabIndex = 71;
            this.cmbAlanHesap.SelectedIndexChanged += new System.EventHandler(this.cmbAlanHesap_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 70;
            this.label6.Text = "Alıcı Hesap";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 77;
            this.label7.Text = "Bakiye";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(22, 105);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(37, 13);
            this.label9.TabIndex = 79;
            this.label9.Text = "Soyad";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(22, 83);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 13);
            this.label10.TabIndex = 76;
            this.label10.Text = "Ad";
            // 
            // lbl_gonderenAd
            // 
            this.lbl_gonderenAd.AutoSize = true;
            this.lbl_gonderenAd.Location = new System.Drawing.Point(147, 83);
            this.lbl_gonderenAd.Name = "lbl_gonderenAd";
            this.lbl_gonderenAd.Size = new System.Drawing.Size(40, 13);
            this.lbl_gonderenAd.TabIndex = 80;
            this.lbl_gonderenAd.Text = "-----------";
            // 
            // lbl_gonderenSoyad
            // 
            this.lbl_gonderenSoyad.AutoSize = true;
            this.lbl_gonderenSoyad.Location = new System.Drawing.Point(147, 105);
            this.lbl_gonderenSoyad.Name = "lbl_gonderenSoyad";
            this.lbl_gonderenSoyad.Size = new System.Drawing.Size(40, 13);
            this.lbl_gonderenSoyad.TabIndex = 81;
            this.lbl_gonderenSoyad.Text = "-----------";
            // 
            // lbl_gonderenBakiye
            // 
            this.lbl_gonderenBakiye.AutoSize = true;
            this.lbl_gonderenBakiye.Location = new System.Drawing.Point(147, 130);
            this.lbl_gonderenBakiye.Name = "lbl_gonderenBakiye";
            this.lbl_gonderenBakiye.Size = new System.Drawing.Size(40, 13);
            this.lbl_gonderenBakiye.TabIndex = 83;
            this.lbl_gonderenBakiye.Text = "-----------";
            // 
            // lbl_alanBakiye
            // 
            this.lbl_alanBakiye.AutoSize = true;
            this.lbl_alanBakiye.Location = new System.Drawing.Point(397, 130);
            this.lbl_alanBakiye.Name = "lbl_alanBakiye";
            this.lbl_alanBakiye.Size = new System.Drawing.Size(40, 13);
            this.lbl_alanBakiye.TabIndex = 87;
            this.lbl_alanBakiye.Text = "-----------";
            // 
            // lbl_alanSoyad
            // 
            this.lbl_alanSoyad.AutoSize = true;
            this.lbl_alanSoyad.Location = new System.Drawing.Point(397, 105);
            this.lbl_alanSoyad.Name = "lbl_alanSoyad";
            this.lbl_alanSoyad.Size = new System.Drawing.Size(40, 13);
            this.lbl_alanSoyad.TabIndex = 85;
            this.lbl_alanSoyad.Text = "-----------";
            // 
            // lbl_alanAd
            // 
            this.lbl_alanAd.AutoSize = true;
            this.lbl_alanAd.Location = new System.Drawing.Point(397, 83);
            this.lbl_alanAd.Name = "lbl_alanAd";
            this.lbl_alanAd.Size = new System.Drawing.Size(40, 13);
            this.lbl_alanAd.TabIndex = 84;
            this.lbl_alanAd.Text = "-----------";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(60, 205);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(101, 13);
            this.label19.TabIndex = 88;
            this.label19.Text = "Gönderilecek Tutar:";
            // 
            // txthavaleTutar
            // 
            this.txthavaleTutar.Location = new System.Drawing.Point(177, 202);
            this.txthavaleTutar.Name = "txthavaleTutar";
            this.txthavaleTutar.Size = new System.Drawing.Size(130, 20);
            this.txthavaleTutar.TabIndex = 89;
            // 
            // btnhavaleYap
            // 
            this.btnhavaleYap.Enabled = false;
            this.btnhavaleYap.Location = new System.Drawing.Point(321, 200);
            this.btnhavaleYap.Name = "btnhavaleYap";
            this.btnhavaleYap.Size = new System.Drawing.Size(80, 23);
            this.btnhavaleYap.TabIndex = 90;
            this.btnhavaleYap.Text = "Havale Yap";
            this.btnhavaleYap.UseVisualStyleBackColor = true;
            this.btnhavaleYap.Click += new System.EventHandler(this.btnhavaleYap_Click);
            // 
            // cmbGonderenTC
            // 
            this.cmbGonderenTC.FormattingEnabled = true;
            this.cmbGonderenTC.Location = new System.Drawing.Point(104, 9);
            this.cmbGonderenTC.Name = "cmbGonderenTC";
            this.cmbGonderenTC.Size = new System.Drawing.Size(121, 21);
            this.cmbGonderenTC.TabIndex = 92;
            this.cmbGonderenTC.SelectedIndexChanged += new System.EventHandler(this.cmbGonderenTC_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 13);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 91;
            this.label11.Text = "Müşteri Tc";
            // 
            // cmbAlanTC
            // 
            this.cmbAlanTC.FormattingEnabled = true;
            this.cmbAlanTC.Location = new System.Drawing.Point(353, 10);
            this.cmbAlanTC.Name = "cmbAlanTC";
            this.cmbAlanTC.Size = new System.Drawing.Size(121, 21);
            this.cmbAlanTC.TabIndex = 94;
            this.cmbAlanTC.SelectedIndexChanged += new System.EventHandler(this.cmbAlanTC_SelectedIndexChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(271, 14);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 93;
            this.label12.Text = "Müşteri Tc";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 77;
            this.label2.Text = "Müsteri Tipi";
            // 
            // lbl_musTipi
            // 
            this.lbl_musTipi.AutoSize = true;
            this.lbl_musTipi.Location = new System.Drawing.Point(147, 159);
            this.lbl_musTipi.Name = "lbl_musTipi";
            this.lbl_musTipi.Size = new System.Drawing.Size(40, 13);
            this.lbl_musTipi.TabIndex = 83;
            this.lbl_musTipi.Text = "-----------";
            // 
            // frm_Havale
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 270);
            this.Controls.Add(this.cmbAlanTC);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbGonderenTC);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnhavaleYap);
            this.Controls.Add(this.txthavaleTutar);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.lbl_alanBakiye);
            this.Controls.Add(this.lbl_alanSoyad);
            this.Controls.Add(this.lbl_alanAd);
            this.Controls.Add(this.lbl_musTipi);
            this.Controls.Add(this.lbl_gonderenBakiye);
            this.Controls.Add(this.lbl_gonderenSoyad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_gonderenAd);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbAlanHesap);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbGonderenHesap);
            this.Controls.Add(this.label4);
            this.Name = "frm_Havale";
            this.Text = "frm_Havale";
            this.Load += new System.EventHandler(this.frm_Havale_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbGonderenHesap;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbAlanHesap;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lbl_gonderenAd;
        private System.Windows.Forms.Label lbl_gonderenSoyad;
        private System.Windows.Forms.Label lbl_gonderenBakiye;
        private System.Windows.Forms.Label lbl_alanBakiye;
        private System.Windows.Forms.Label lbl_alanSoyad;
        private System.Windows.Forms.Label lbl_alanAd;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txthavaleTutar;
        private System.Windows.Forms.Button btnhavaleYap;
        private System.Windows.Forms.ComboBox cmbGonderenTC;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cmbAlanTC;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_musTipi;
    }
}