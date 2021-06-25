using System;
using System.Diagnostics;

namespace Tubes_KPL
{
    class InputJasaModel
    {
        private String mataUang;
        private String namaToko;
        private String namaJasa;
        private String deskripsi;
        private double hargaPerPaket;
        private int jumlahPaket;

        public InputJasaModel()
        {

        }

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
            this.hargaPerPaket = hargaPerPaket;
        }

        public double getHargaPerPaket()
        {
            return this.hargaPerPaket;
        }

        public void setJumlahPaket(int jumlahPaket)
        {
            this.jumlahPaket = jumlahPaket;
        }

        public int getJumlahPaket()
        {
            return this.jumlahPaket;
        }

    }
}
