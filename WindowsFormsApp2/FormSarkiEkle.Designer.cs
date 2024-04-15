namespace WindowsFormsApp2
{
    partial class FormSarkiEkle
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
            this.txtSanatci = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSarkiAdi = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtTarih = new System.Windows.Forms.DateTimePicker();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtYil = new System.Windows.Forms.TextBox();
            this.txtSure = new System.Windows.Forms.TextBox();
            this.cmbTur = new System.Windows.Forms.ComboBox();
            this.cbFovari = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "şarkı adı:";
            // 
            // txtSanatci
            // 
            this.txtSanatci.AutoSize = true;
            this.txtSanatci.Location = new System.Drawing.Point(47, 87);
            this.txtSanatci.Name = "txtSanatci";
            this.txtSanatci.Size = new System.Drawing.Size(44, 13);
            this.txtSanatci.TabIndex = 1;
            this.txtSanatci.Text = "sanatçı:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "yıl:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "tür:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "süre:";
            // 
            // txtSarkiAdi
            // 
            this.txtSarkiAdi.Location = new System.Drawing.Point(102, 44);
            this.txtSarkiAdi.Name = "txtSarkiAdi";
            this.txtSarkiAdi.Size = new System.Drawing.Size(100, 20);
            this.txtSarkiAdi.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(102, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(305, 115);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "eklenme tarihi:";
            // 
            // dtTarih
            // 
            this.dtTarih.Location = new System.Drawing.Point(397, 109);
            this.dtTarih.Name = "dtTarih";
            this.dtTarih.Size = new System.Drawing.Size(200, 20);
            this.dtTarih.TabIndex = 9;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(35, 211);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(188, 65);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "şarkı ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtYil
            // 
            this.txtYil.Location = new System.Drawing.Point(102, 117);
            this.txtYil.Name = "txtYil";
            this.txtYil.Size = new System.Drawing.Size(100, 20);
            this.txtYil.TabIndex = 14;
            // 
            // txtSure
            // 
            this.txtSure.Location = new System.Drawing.Point(397, 77);
            this.txtSure.Name = "txtSure";
            this.txtSure.Size = new System.Drawing.Size(100, 20);
            this.txtSure.TabIndex = 15;
            // 
            // cmbTur
            // 
            this.cmbTur.FormattingEnabled = true;
            this.cmbTur.Location = new System.Drawing.Point(397, 36);
            this.cmbTur.Name = "cmbTur";
            this.cmbTur.Size = new System.Drawing.Size(121, 21);
            this.cmbTur.TabIndex = 16;
            // 
            // cbFovari
            // 
            this.cbFovari.AutoSize = true;
            this.cbFovari.Location = new System.Drawing.Point(84, 178);
            this.cbFovari.Name = "cbFovari";
            this.cbFovari.Size = new System.Drawing.Size(52, 17);
            this.cbFovari.TabIndex = 17;
            this.cbFovari.Text = "fovari";
            this.cbFovari.UseVisualStyleBackColor = true;
            // 
            // FormSarkiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(643, 305);
            this.Controls.Add(this.cbFovari);
            this.Controls.Add(this.cmbTur);
            this.Controls.Add(this.txtSure);
            this.Controls.Add(this.txtYil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dtTarih);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txtSarkiAdi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtSanatci);
            this.Controls.Add(this.label1);
            this.Name = "FormSarkiEkle";
            this.Text = "FormSarkiEkle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label txtSanatci;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSarkiAdi;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtTarih;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtYil;
        private System.Windows.Forms.TextBox txtSure;
        private System.Windows.Forms.ComboBox cmbTur;
        private System.Windows.Forms.CheckBox cbFovari;
    }
}