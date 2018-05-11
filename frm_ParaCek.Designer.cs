namespace BankaOtomasyonu
{
    partial class frm_ParaCek
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
            this.lbl_bakiye = new System.Windows.Forms.Label();
            this.lbl_Tc = new System.Windows.Forms.Label();
            this.lbl_soyad = new System.Windows.Forms.Label();
            this.lbl_ad = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tutar = new System.Windows.Forms.TextBox();
            this.btn_ParaCek = new System.Windows.Forms.Button();
            this.cmbmusteritc = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbara
            // 
            this.cmbara.FormattingEnabled = true;
            this.cmbara.Location = new System.Drawing.Point(102, 45);
            this.cmbara.Name = "cmbara";
            this.cmbara.Size = new System.Drawing.Size(121, 21);
            this.cmbara.TabIndex = 61;
            this.cmbara.SelectedIndexChanged += new System.EventHandler(this.cmbara_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 48);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "Hesap No";
            // 
            // lbl_bakiye
            // 
            this.lbl_bakiye.AutoSize = true;
            this.lbl_bakiye.Location = new System.Drawing.Point(131, 155);
            this.lbl_bakiye.Name = "lbl_bakiye";
            this.lbl_bakiye.Size = new System.Drawing.Size(22, 13);
            this.lbl_bakiye.TabIndex = 65;
            this.lbl_bakiye.Text = "-----";
            // 
            // lbl_Tc
            // 
            this.lbl_Tc.AutoSize = true;
            this.lbl_Tc.Location = new System.Drawing.Point(130, 133);
            this.lbl_Tc.Name = "lbl_Tc";
            this.lbl_Tc.Size = new System.Drawing.Size(22, 13);
            this.lbl_Tc.TabIndex = 66;
            this.lbl_Tc.Text = "-----";
            // 
            // lbl_soyad
            // 
            this.lbl_soyad.AutoSize = true;
            this.lbl_soyad.Location = new System.Drawing.Point(130, 111);
            this.lbl_soyad.Name = "lbl_soyad";
            this.lbl_soyad.Size = new System.Drawing.Size(22, 13);
            this.lbl_soyad.TabIndex = 67;
            this.lbl_soyad.Text = "-----";
            // 
            // lbl_ad
            // 
            this.lbl_ad.AutoSize = true;
            this.lbl_ad.Location = new System.Drawing.Point(130, 88);
            this.lbl_ad.Name = "lbl_ad";
            this.lbl_ad.Size = new System.Drawing.Size(22, 13);
            this.lbl_ad.TabIndex = 64;
            this.lbl_ad.Text = "-----";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 189);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 67;
            this.label1.Text = "Çekilecek Tutar";
            // 
            // txt_tutar
            // 
            this.txt_tutar.Location = new System.Drawing.Point(123, 186);
            this.txt_tutar.Name = "txt_tutar";
            this.txt_tutar.Size = new System.Drawing.Size(100, 20);
            this.txt_tutar.TabIndex = 68;
            // 
            // btn_ParaCek
            // 
            this.btn_ParaCek.Location = new System.Drawing.Point(89, 221);
            this.btn_ParaCek.Name = "btn_ParaCek";
            this.btn_ParaCek.Size = new System.Drawing.Size(75, 23);
            this.btn_ParaCek.TabIndex = 69;
            this.btn_ParaCek.Text = "Para Çek";
            this.btn_ParaCek.UseVisualStyleBackColor = true;
            this.btn_ParaCek.Click += new System.EventHandler(this.btn_ParaCek_Click);
            // 
            // cmbmusteritc
            // 
            this.cmbmusteritc.FormattingEnabled = true;
            this.cmbmusteritc.Location = new System.Drawing.Point(102, 18);
            this.cmbmusteritc.Name = "cmbmusteritc";
            this.cmbmusteritc.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteritc.TabIndex = 81;
            this.cmbmusteritc.SelectedIndexChanged += new System.EventHandler(this.cmbmusteritc_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 22);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 80;
            this.label2.Text = "Müşteri Tc";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 83;
            this.label3.Text = "Bakiye";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 13);
            this.label5.TabIndex = 84;
            this.label5.Text = "Tc";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(85, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Soyad";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(85, 88);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(20, 13);
            this.label7.TabIndex = 82;
            this.label7.Text = "Ad";
            // 
            // frm_ParaCek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 260);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbmusteritc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ParaCek);
            this.Controls.Add(this.txt_tutar);
            this.Controls.Add(this.lbl_bakiye);
            this.Controls.Add(this.lbl_Tc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_soyad);
            this.Controls.Add(this.lbl_ad);
            this.Controls.Add(this.cmbara);
            this.Controls.Add(this.label4);
            this.Name = "frm_ParaCek";
            this.Text = "frm_ParaCek";
            this.Load += new System.EventHandler(this.frm_ParaCek_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbara;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_bakiye;
        private System.Windows.Forms.Label lbl_Tc;
        private System.Windows.Forms.Label lbl_soyad;
        private System.Windows.Forms.Label lbl_ad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tutar;
        private System.Windows.Forms.Button btn_ParaCek;
        private System.Windows.Forms.ComboBox cmbmusteritc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}