namespace BankaOtomasyonu
{
    partial class frm_HesapAc
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
            this.label5 = new System.Windows.Forms.Label();
            this.rdb_vadesiz = new System.Windows.Forms.RadioButton();
            this.rdb_vadeli = new System.Windows.Forms.RadioButton();
            this.btn_hesapac = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_bakiye = new System.Windows.Forms.TextBox();
            this.cmbmusteritc = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 13);
            this.label5.TabIndex = 72;
            this.label5.Text = "Müşteri Tc";
            // 
            // rdb_vadesiz
            // 
            this.rdb_vadesiz.AutoSize = true;
            this.rdb_vadesiz.Location = new System.Drawing.Point(163, 86);
            this.rdb_vadesiz.Name = "rdb_vadesiz";
            this.rdb_vadesiz.Size = new System.Drawing.Size(62, 17);
            this.rdb_vadesiz.TabIndex = 71;
            this.rdb_vadesiz.TabStop = true;
            this.rdb_vadesiz.Text = "Vadesiz";
            this.rdb_vadesiz.UseVisualStyleBackColor = true;
            // 
            // rdb_vadeli
            // 
            this.rdb_vadeli.AutoSize = true;
            this.rdb_vadeli.Location = new System.Drawing.Point(104, 86);
            this.rdb_vadeli.Name = "rdb_vadeli";
            this.rdb_vadeli.Size = new System.Drawing.Size(54, 17);
            this.rdb_vadeli.TabIndex = 70;
            this.rdb_vadeli.TabStop = true;
            this.rdb_vadeli.Text = "Vadeli";
            this.rdb_vadeli.UseVisualStyleBackColor = true;
            // 
            // btn_hesapac
            // 
            this.btn_hesapac.Location = new System.Drawing.Point(83, 125);
            this.btn_hesapac.Name = "btn_hesapac";
            this.btn_hesapac.Size = new System.Drawing.Size(75, 23);
            this.btn_hesapac.TabIndex = 69;
            this.btn_hesapac.Text = "Hesap Aç";
            this.btn_hesapac.UseVisualStyleBackColor = true;
            this.btn_hesapac.Click += new System.EventHandler(this.btn_hesapac_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "Hesap Türü";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 66;
            this.label2.Text = "Bakiye";
            // 
            // txt_bakiye
            // 
            this.txt_bakiye.Location = new System.Drawing.Point(104, 51);
            this.txt_bakiye.Name = "txt_bakiye";
            this.txt_bakiye.Size = new System.Drawing.Size(121, 20);
            this.txt_bakiye.TabIndex = 63;
            // 
            // cmbmusteritc
            // 
            this.cmbmusteritc.FormattingEnabled = true;
            this.cmbmusteritc.Location = new System.Drawing.Point(104, 17);
            this.cmbmusteritc.Name = "cmbmusteritc";
            this.cmbmusteritc.Size = new System.Drawing.Size(121, 21);
            this.cmbmusteritc.TabIndex = 73;
            this.cmbmusteritc.SelectedIndexChanged += new System.EventHandler(this.cmbmusteritc_SelectedIndexChanged);
            // 
            // frm_HesapAc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(262, 178);
            this.Controls.Add(this.cmbmusteritc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rdb_vadesiz);
            this.Controls.Add(this.rdb_vadeli);
            this.Controls.Add(this.btn_hesapac);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_bakiye);
            this.Name = "frm_HesapAc";
            this.Text = "frm_HesapAc";
            this.Load += new System.EventHandler(this.frm_HesapAc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton rdb_vadesiz;
        private System.Windows.Forms.RadioButton rdb_vadeli;
        private System.Windows.Forms.Button btn_hesapac;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_bakiye;
        private System.Windows.Forms.ComboBox cmbmusteritc;
    }
}