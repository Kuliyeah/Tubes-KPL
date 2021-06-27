using System;
using System.Diagnostics;
using System.IO;

namespace Tubes_KPL
{
    public class InputJasaModel
    {
        // Inisialisasi variabel yang dibutuhkan pada atribut jasa.
        private String mataUang;
        private String namaToko;
        private String namaJasa;
        private String deskripsi;
        private double hargaPerPaket;
        private int jumlahPaket;

        // Constructor kosong.
        public InputJasaModel()
        {

        }

        // Constructor yang berisi nilai dari parameter input dan akan disimpan pada variabel sebelumnya.
        public InputJasaModel(string mataUang, string namaToko, string namaJasa, double hargaPerPaket, int jumlahPaket, string deskripsi)
        {
            this.mataUang = mataUang;
            Debug.Assert(jumlahPaket >= 2, "Jumlah Paket harus lebih dari 2");
            Debug.Assert(hargaPerPaket >= 5000, "Harga barang harus lebih dari 5000");
            this.namaToko = namaToko;
            this.namaJasa = namaJasa;
            this.deskripsi = deskripsi;
            this.hargaPerPaket = hargaPerPaket;
            this.jumlahPaket = jumlahPaket;
        }

        // Getter dan Setter dari value variabel yang dibutuhkan sebelumnya.
        public void setMataUang(string mataUang)
        {
            this.mataUang = mataUang;
        }

        public String getMataUang()
        {
            return this.mataUang;
        }

        public void setNamaToko(string namaToko)
        {
            this.namaToko = namaToko;
        }

        public String getNamaToko()
        {
            return this.namaToko;
        }

        public void setNamaJasa(string namaJasa)
        {
            this.namaJasa = namaJasa;
        }

        public String getNamaJasa()
        {
            return this.namaJasa;
        }

        public void setDeskripsi(string deskripsi)
        {
            this.deskripsi = deskripsi;
        }

        public String getDeskripsi()
        {
            return this.deskripsi;
        }

        public void setHargaPerPaket(double hargaPerPaket)
        {
            Debug.Assert(hargaPerPaket >= 5000, "Harga barang harus lebih dari 5000");
            this.hargaPerPaket = hargaPerPaket;
        }

        public double getHargaPerPaket()
        {
            return this.hargaPerPaket;
        }

        public void setJumlahPaket(int jumlahPaket)
        {
            Debug.Assert(jumlahPaket >= 2, "Jumlah Paket harus lebih dari 2");
            this.jumlahPaket = jumlahPaket;
        }

        public int getJumlahPaket()
        {
            return this.jumlahPaket;
        }

        // End Getter dan Setter.

        // Unit Testing untuk mengecek apakah terdapat file MoneyConfig.json pada projek ini
        public bool isExitingFileJson()
        {
            if (File.Exists("../../../json/MoneyConfig.json"))
            {
                return true;
            }
            return false;
        }
    }
}
