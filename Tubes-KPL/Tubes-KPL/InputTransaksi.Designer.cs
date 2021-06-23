
namespace Tubes_KPL
{
    partial class InputTransaksi
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
            this.dataGridTransaksi = new System.Windows.Forms.DataGridView();
            this.textOngkir = new System.Windows.Forms.TextBox();
            this.textDeskripsi = new System.Windows.Forms.TextBox();
            this.textBerat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textIDTransaksi = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSimpan = new System.Windows.Forms.Button();
            this.btnBatal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxNamaJasa = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.textTotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textTanggal = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.LbMoney = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridTransaksi
            // 
            this.dataGridTransaksi.BackgroundColor = System.Drawing.Color.White;
            this.dataGridTransaksi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTransaksi.Location = new System.Drawing.Point(350, 37);
            this.dataGridTransaksi.Name = "dataGridTransaksi";
            this.dataGridTransaksi.Size = new System.Drawing.Size(763, 343);
            this.dataGridTransaksi.TabIndex = 37;
            // 
            // textOngkir
            // 
            this.textOngkir.Location = new System.Drawing.Point(129, 185);
            this.textOngkir.Name = "textOngkir";
            this.textOngkir.Size = new System.Drawing.Size(193, 20);
            this.textOngkir.TabIndex = 31;
            // 
            // textDeskripsi
            // 
            this.textDeskripsi.Location = new System.Drawing.Point(110, 261);
            this.textDeskripsi.Multiline = true;
            this.textDeskripsi.Name = "textDeskripsi";
            this.textDeskripsi.Size = new System.Drawing.Size(212, 70);
            this.textDeskripsi.TabIndex = 32;
            // 
            // textBerat
            // 
            this.textBerat.Location = new System.Drawing.Point(110, 146);
            this.textBerat.Name = "textBerat";
            this.textBerat.Size = new System.Drawing.Size(212, 20);
            this.textBerat.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 26;
            this.label4.Text = "Ongkir";
            // 
            // textIDTransaksi
            // 
            this.textIDTransaksi.Location = new System.Drawing.Point(110, 74);
            this.textIDTransaksi.Name = "textIDTransaksi";
            this.textIDTransaksi.Size = new System.Drawing.Size(61, 20);
            this.textIDTransaksi.TabIndex = 34;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 264);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Deskripsi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Berat";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(347, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Data :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 30;
            this.label2.Text = "No Transaksi";
            // 
            // btnSimpan
            // 
            this.btnSimpan.Location = new System.Drawing.Point(143, 357);
            this.btnSimpan.Name = "btnSimpan";
            this.btnSimpan.Size = new System.Drawing.Size(79, 23);
            this.btnSimpan.TabIndex = 24;
            this.btnSimpan.Text = "Simpan";
            this.btnSimpan.UseVisualStyleBackColor = true;
            this.btnSimpan.Click += new System.EventHandler(this.btnSimpan_Click);
            // 
            // btnBatal
            // 
            this.btnBatal.Location = new System.Drawing.Point(241, 357);
            this.btnBatal.Name = "btnBatal";
            this.btnBatal.Size = new System.Drawing.Size(79, 23);
            this.btnBatal.TabIndex = 25;
            this.btnBatal.Text = "Batal";
            this.btnBatal.UseVisualStyleBackColor = true;
            this.btnBatal.Click += new System.EventHandler(this.btnBatal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(106, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "INPUT TRANSAKSI";
            // 
            // comboBoxNamaJasa
            // 
            this.comboBoxNamaJasa.FormattingEnabled = true;
            this.comboBoxNamaJasa.Location = new System.Drawing.Point(110, 109);
            this.comboBoxNamaJasa.Name = "comboBoxNamaJasa";
            this.comboBoxNamaJasa.Size = new System.Drawing.Size(210, 21);
            this.comboBoxNamaJasa.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(36, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 39;
            this.label7.Text = "Nama Jasa";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(39, 357);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(79, 23);
            this.btnNew.TabIndex = 40;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // textTotal
            // 
            this.textTotal.Location = new System.Drawing.Point(129, 223);
            this.textTotal.Name = "textTotal";
            this.textTotal.Size = new System.Drawing.Size(193, 20);
            this.textTotal.TabIndex = 42;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(36, 226);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 13);
            this.label8.TabIndex = 41;
            this.label8.Text = "Total Bayar";
            // 
            // textTanggal
            // 
            this.textTanggal.Location = new System.Drawing.Point(190, 74);
            this.textTanggal.Name = "textTanggal";
            this.textTanggal.Size = new System.Drawing.Size(130, 20);
            this.textTanggal.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(270, 58);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(52, 13);
            this.label9.TabIndex = 44;
            this.label9.Text = "Tanggal :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(107, 188);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(24, 13);
            this.label10.TabIndex = 46;
            this.label10.Text = "Rp.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(107, 226);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(24, 13);
            this.label11.TabIndex = 47;
            this.label11.Text = "Rp.";
            // 
            // LbMoney
            // 
            this.LbMoney.AutoSize = true;
            this.LbMoney.Location = new System.Drawing.Point(996, 21);
            this.LbMoney.Name = "LbMoney";
            this.LbMoney.Size = new System.Drawing.Size(69, 13);
            this.LbMoney.TabIndex = 48;
            this.LbMoney.Text = "Mata Uang : ";
            // 
            // InputTransaksi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1151, 450);
            this.Controls.Add(this.LbMoney);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.textTanggal);
            this.Controls.Add(this.textTotal);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxNamaJasa);
            this.Controls.Add(this.dataGridTransaksi);
            this.Controls.Add(this.textOngkir);
            this.Controls.Add(this.textDeskripsi);
            this.Controls.Add(this.textBerat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textIDTransaksi);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSimpan);
            this.Controls.Add(this.btnBatal);
            this.Controls.Add(this.label1);
            this.Name = "InputTransaksi";
            this.Text = "Input Transaksi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTransaksi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridTransaksi;
        private System.Windows.Forms.TextBox textOngkir;
        private System.Windows.Forms.TextBox textDeskripsi;
        private System.Windows.Forms.TextBox textBerat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textIDTransaksi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSimpan;
        private System.Windows.Forms.Button btnBatal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxNamaJasa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.TextBox textTotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textTanggal;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LbMoney;
    }
}