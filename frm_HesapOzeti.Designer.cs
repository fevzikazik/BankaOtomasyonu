namespace BankaOtomasyonu
{
    partial class frm_HesapOzeti
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
            this.dtp_ilkTarih = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_sonTarih = new System.Windows.Forms.DateTimePicker();
            this.cmb_HesapNo = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtGrdMusteriler = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTCKN = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblAd = new System.Windows.Forms.Label();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdMusteriler)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_ilkTarih
            // 
            this.dtp_ilkTarih.Location = new System.Drawing.Point(155, 45);
            this.dtp_ilkTarih.Name = "dtp_ilkTarih";
            this.dtp_ilkTarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_ilkTarih.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(62, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "HesapNo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Son Tarih:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "İlkTarih:";
            // 
            // dtp_sonTarih
            // 
            this.dtp_sonTarih.Location = new System.Drawing.Point(155, 71);
            this.dtp_sonTarih.Name = "dtp_sonTarih";
            this.dtp_sonTarih.Size = new System.Drawing.Size(200, 20);
            this.dtp_sonTarih.TabIndex = 6;
            // 
            // cmb_HesapNo
            // 
            this.cmb_HesapNo.FormattingEnabled = true;
            this.cmb_HesapNo.Location = new System.Drawing.Point(155, 18);
            this.cmb_HesapNo.Name = "cmb_HesapNo";
            this.cmb_HesapNo.Size = new System.Drawing.Size(200, 21);
            this.cmb_HesapNo.TabIndex = 66;
            this.cmb_HesapNo.SelectedIndexChanged += new System.EventHandler(this.cmb_HesapNo_SelectedIndexChanged);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtGrdMusteriler);
            this.groupBox5.Location = new System.Drawing.Point(19, 119);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(526, 189);
            this.groupBox5.TabIndex = 67;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Hesap Özeti";
            // 
            // dtGrdMusteriler
            // 
            this.dtGrdMusteriler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrdMusteriler.Location = new System.Drawing.Point(21, 26);
            this.dtGrdMusteriler.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrdMusteriler.Name = "dtGrdMusteriler";
            this.dtGrdMusteriler.ReadOnly = true;
            this.dtGrdMusteriler.RowTemplate.Height = 24;
            this.dtGrdMusteriler.Size = new System.Drawing.Size(486, 147);
            this.dtGrdMusteriler.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(263, 97);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(68, 20);
            this.button1.TabIndex = 68;
            this.button1.Text = "Göster";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 69;
            this.label4.Text = "Adı: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 70;
            this.label5.Text = "Soyadı: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(42, 13);
            this.label6.TabIndex = 71;
            this.label6.Text = "TCKN: ";
            // 
            // lblTCKN
            // 
            this.lblTCKN.AutoSize = true;
            this.lblTCKN.Location = new System.Drawing.Point(442, 76);
            this.lblTCKN.Name = "lblTCKN";
            this.lblTCKN.Size = new System.Drawing.Size(25, 13);
            this.lblTCKN.TabIndex = 74;
            this.lblTCKN.Text = "------";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(442, 50);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(25, 13);
            this.lblSoyad.TabIndex = 73;
            this.lblSoyad.Text = "------";
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(442, 21);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(25, 13);
            this.lblAd.TabIndex = 72;
            this.lblAd.Text = "------";
            // 
            // frm_HesapOzeti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 325);
            this.Controls.Add(this.lblTCKN);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.cmb_HesapNo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dtp_sonTarih);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dtp_ilkTarih);
            this.Controls.Add(this.label1);
            this.Name = "frm_HesapOzeti";
            this.Text = "frm_HesapOzeti";
            this.Load += new System.EventHandler(this.frm_HesapOzeti_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrdMusteriler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_ilkTarih;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_sonTarih;
        private System.Windows.Forms.ComboBox cmb_HesapNo;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtGrdMusteriler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTCKN;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblAd;
    }
}