
namespace Tubes_KPL
{
    partial class Dashboard
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
            this.btnDataTransaksi = new System.Windows.Forms.Button();
            this.btnDataJasa = new System.Windows.Forms.Button();
            this.btnDataPengguna = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLogout = new System.Windows.Forms.Button();
            this.cbMoney = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDataTransaksi
            // 
            this.btnDataTransaksi.Location = new System.Drawing.Point(665, 395);
            this.btnDataTransaksi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDataTransaksi.Name = "btnDataTransaksi";
            this.btnDataTransaksi.Size = new System.Drawing.Size(167, 42);
            this.btnDataTransaksi.TabIndex = 12;
            this.btnDataTransaksi.Text = "Data Transaksi";
            this.btnDataTransaksi.UseVisualStyleBackColor = true;
            this.btnDataTransaksi.Click += new System.EventHandler(this.btnDataTransaksi_Click);
            // 
            // btnDataJasa
            // 
            this.btnDataJasa.Location = new System.Drawing.Point(443, 395);
            this.btnDataJasa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDataJasa.Name = "btnDataJasa";
            this.btnDataJasa.Size = new System.Drawing.Size(167, 42);
            this.btnDataJasa.TabIndex = 11;
            this.btnDataJasa.Text = "Data Jasa";
            this.btnDataJasa.UseVisualStyleBackColor = true;
            this.btnDataJasa.Click += new System.EventHandler(this.btnDataJasa_Click);
            // 
            // btnDataPengguna
            // 
            this.btnDataPengguna.Location = new System.Drawing.Point(228, 395);
            this.btnDataPengguna.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDataPengguna.Name = "btnDataPengguna";
            this.btnDataPengguna.Size = new System.Drawing.Size(167, 42);
            this.btnDataPengguna.TabIndex = 10;
            this.btnDataPengguna.Text = "Data Pengguna";
            this.btnDataPengguna.UseVisualStyleBackColor = true;
            this.btnDataPengguna.Click += new System.EventHandler(this.btnDataPengguna_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(855, 527);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Selamat datang kembali";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(416, 330);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 29);
            this.label1.TabIndex = 8;
            this.label1.Text = "FLASH LAUNDRY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Tubes_KPL.Properties.Resources.Asset_1;
            this.pictureBox1.Location = new System.Drawing.Point(376, 89);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 203);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(965, 14);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 32);
            this.btnLogout.TabIndex = 13;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // cbMoney
            // 
            this.cbMoney.FormattingEnabled = true;
            this.cbMoney.Items.AddRange(new object[] {
            "Rupiah",
            "USD"});
            this.cbMoney.Location = new System.Drawing.Point(16, 44);
            this.cbMoney.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbMoney.Name = "cbMoney";
            this.cbMoney.Size = new System.Drawing.Size(160, 24);
            this.cbMoney.TabIndex = 14;
            this.cbMoney.SelectedIndexChanged += new System.EventHandler(this.comboBoxMoney_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 21);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "Ganti Mata Uang";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbMoney);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.btnDataTransaksi);
            this.Controls.Add(this.btnDataJasa);
            this.Controls.Add(this.btnDataPengguna);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDataTransaksi;
        private System.Windows.Forms.Button btnDataJasa;
        private System.Windows.Forms.Button btnDataPengguna;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.ComboBox cbMoney;
        private System.Windows.Forms.Label label3;
    }
}