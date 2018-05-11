namespace BankaOtomasyonu
{
    partial class frm_GelirGider
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lbl_gelenPara = new System.Windows.Forms.Label();
            this.lbl_gidenPara = new System.Windows.Forms.Label();
            this.lbl_toplamPara = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.dtGrvGelir = new System.Windows.Forms.DataGridView();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dtGrwGider = new System.Windows.Forms.DataGridView();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvGelir)).BeginInit();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrwGider)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bankaya Gelen Para: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Bankadan Giden Para: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(550, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Mevcut Toplam Banka Bakiyesi:";
            // 
            // lbl_gelenPara
            // 
            this.lbl_gelenPara.AutoSize = true;
            this.lbl_gelenPara.Location = new System.Drawing.Point(213, 23);
            this.lbl_gelenPara.Name = "lbl_gelenPara";
            this.lbl_gelenPara.Size = new System.Drawing.Size(40, 13);
            this.lbl_gelenPara.TabIndex = 81;
            this.lbl_gelenPara.Text = "-----------";
            // 
            // lbl_gidenPara
            // 
            this.lbl_gidenPara.AutoSize = true;
            this.lbl_gidenPara.Location = new System.Drawing.Point(480, 23);
            this.lbl_gidenPara.Name = "lbl_gidenPara";
            this.lbl_gidenPara.Size = new System.Drawing.Size(40, 13);
            this.lbl_gidenPara.TabIndex = 82;
            this.lbl_gidenPara.Text = "-----------";
            // 
            // lbl_toplamPara
            // 
            this.lbl_toplamPara.AutoSize = true;
            this.lbl_toplamPara.Location = new System.Drawing.Point(716, 23);
            this.lbl_toplamPara.Name = "lbl_toplamPara";
            this.lbl_toplamPara.Size = new System.Drawing.Size(40, 13);
            this.lbl_toplamPara.TabIndex = 83;
            this.lbl_toplamPara.Text = "-----------";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.dtGrvGelir);
            this.groupBox5.Location = new System.Drawing.Point(26, 242);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox5.Size = new System.Drawing.Size(776, 162);
            this.groupBox5.TabIndex = 85;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Gelir Raporu";
            // 
            // dtGrvGelir
            // 
            this.dtGrvGelir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrvGelir.Location = new System.Drawing.Point(14, 17);
            this.dtGrvGelir.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrvGelir.Name = "dtGrvGelir";
            this.dtGrvGelir.ReadOnly = true;
            this.dtGrvGelir.RowTemplate.Height = 24;
            this.dtGrvGelir.Size = new System.Drawing.Size(742, 114);
            this.dtGrvGelir.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dtGrwGider);
            this.groupBox4.Location = new System.Drawing.Point(26, 58);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox4.Size = new System.Drawing.Size(776, 167);
            this.groupBox4.TabIndex = 84;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Gider Raporu";
            // 
            // dtGrwGider
            // 
            this.dtGrwGider.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrwGider.Location = new System.Drawing.Point(14, 26);
            this.dtGrwGider.Margin = new System.Windows.Forms.Padding(2);
            this.dtGrwGider.Name = "dtGrwGider";
            this.dtGrwGider.ReadOnly = true;
            this.dtGrwGider.RowTemplate.Height = 24;
            this.dtGrwGider.Size = new System.Drawing.Size(742, 130);
            this.dtGrwGider.TabIndex = 0;
            // 
            // frm_GelirGider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 425);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.lbl_toplamPara);
            this.Controls.Add(this.lbl_gidenPara);
            this.Controls.Add(this.lbl_gelenPara);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "frm_GelirGider";
            this.Text = "frm_GelirGider";
            this.Load += new System.EventHandler(this.frm_GelirGider_Load);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrvGelir)).EndInit();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGrwGider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lbl_gelenPara;
        private System.Windows.Forms.Label lbl_gidenPara;
        private System.Windows.Forms.Label lbl_toplamPara;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView dtGrvGelir;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dtGrwGider;
    }
}