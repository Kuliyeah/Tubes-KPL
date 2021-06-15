
namespace Tubes_KPL
{
    partial class HalamanUtama
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnDataPengguna = new System.Windows.Forms.Button();
            this.btnDataJasa = new System.Windows.Forms.Button();
            this.btnDataTransaksi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(334, 369);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "FLASH LAUNDRY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tubes_KPL.Properties.Resources.Asset_1;
            this.pictureBox1.Location = new System.Drawing.Point(314, 173);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(225, 165);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(634, 425);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Selamat datang kembali";
            // 
            // btnDataPengguna
            // 
            this.btnDataPengguna.Location = new System.Drawing.Point(84, 63);
            this.btnDataPengguna.Name = "btnDataPengguna";
            this.btnDataPengguna.Size = new System.Drawing.Size(125, 34);
            this.btnDataPengguna.TabIndex = 4;
            this.btnDataPengguna.Text = "Data Pengguna";
            this.btnDataPengguna.UseVisualStyleBackColor = true;
            this.btnDataPengguna.Click += new System.EventHandler(this.btnDataPengguna_Click);
            // 
            // btnDataJasa
            // 
            this.btnDataJasa.Location = new System.Drawing.Point(369, 63);
            this.btnDataJasa.Name = "btnDataJasa";
            this.btnDataJasa.Size = new System.Drawing.Size(125, 34);
            this.btnDataJasa.TabIndex = 5;
            this.btnDataJasa.Text = "Data Jasa";
            this.btnDataJasa.UseVisualStyleBackColor = true;
            this.btnDataJasa.Click += new System.EventHandler(this.btnDataJasa_Click);
            // 
            // btnDataTransaksi
            // 
            this.btnDataTransaksi.Location = new System.Drawing.Point(619, 63);
            this.btnDataTransaksi.Name = "btnDataTransaksi";
            this.btnDataTransaksi.Size = new System.Drawing.Size(125, 34);
            this.btnDataTransaksi.TabIndex = 6;
            this.btnDataTransaksi.Text = "Data Transaksi";
            this.btnDataTransaksi.UseVisualStyleBackColor = true;
            this.btnDataTransaksi.Click += new System.EventHandler(this.btnDataTransaksi_Click);
            // 
            // HalamanUtama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDataTransaksi);
            this.Controls.Add(this.btnDataJasa);
            this.Controls.Add(this.btnDataPengguna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "HalamanUtama";
            this.Text = "Halaman Utama";
            this.Load += new System.EventHandler(this.HalamanUtama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnDataPengguna;
        private System.Windows.Forms.Button btnDataJasa;
        private System.Windows.Forms.Button btnDataTransaksi;
    }
}