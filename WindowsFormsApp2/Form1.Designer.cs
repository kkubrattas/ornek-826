namespace WindowsFormsApp2
{
    partial class Form1
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
            this.btnSarkiEkle = new System.Windows.Forms.Button();
            this.btnTumSarkilar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSarkiEkle
            // 
            this.btnSarkiEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSarkiEkle.Location = new System.Drawing.Point(31, 27);
            this.btnSarkiEkle.Name = "btnSarkiEkle";
            this.btnSarkiEkle.Size = new System.Drawing.Size(148, 115);
            this.btnSarkiEkle.TabIndex = 0;
            this.btnSarkiEkle.Text = "şarkı ekle";
            this.btnSarkiEkle.UseVisualStyleBackColor = true;
            this.btnSarkiEkle.Click += new System.EventHandler(this.btnSarkiEkle_Click);
            // 
            // btnTumSarkilar
            // 
            this.btnTumSarkilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTumSarkilar.Location = new System.Drawing.Point(204, 27);
            this.btnTumSarkilar.Name = "btnTumSarkilar";
            this.btnTumSarkilar.Size = new System.Drawing.Size(135, 115);
            this.btnTumSarkilar.TabIndex = 1;
            this.btnTumSarkilar.Text = "tüm şarkılar";
            this.btnTumSarkilar.UseVisualStyleBackColor = true;
            this.btnTumSarkilar.Click += new System.EventHandler(this.btnTumSarkilar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 198);
            this.Controls.Add(this.btnTumSarkilar);
            this.Controls.Add(this.btnSarkiEkle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSarkiEkle;
        private System.Windows.Forms.Button btnTumSarkilar;
    }
}

