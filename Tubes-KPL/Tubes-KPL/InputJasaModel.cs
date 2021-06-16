using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class InputJasaModel
    {
        String namaToko, namaJasa, deskripsi;
        int hargaPerPaket, jumlahPaket;

        public InputJasaModel(string namaToko, string namaJasa, int hargaPerPaket, int jumlahPaket, string deskripsi)
        {
            this.namaToko = namaToko;
            this.namaJasa = namaJasa;
            this.deskripsi = deskripsi;
            this.hargaPerPaket = hargaPerPaket;
            this.jumlahPaket = jumlahPaket;
        }

        public InputJasaModel()
        {

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
        public void setHarga(int hargaPerPaket)
        {
            this.hargaPerPaket = hargaPerPaket;
        }
        public int getHarga()
        {
            return this.hargaPerPaket;
        }
        public void setDeskripsi(String deskripsi)
        {
            this.deskripsi = deskripsi;
        }
        public String getDeskripsi()
        {
            return this.deskripsi;
        }

        public void setJumlahPaket(int jumlahPaket)
        {
            this.jumlahPaket = jumlahPaket;
        }
        public int getJumlahPaket()
        {
            return this.jumlahPaket;
        }

        public int getTotalMinimalHarga(int jumlahPaket, int hargaPaket)
        {
            // Post Condition (DESIGN BY CONTRACT)
            jumlahPaket = getJumlahPaket();
            hargaPaket = getHarga();
            Debug.Assert(jumlahPaket <= int.MaxValue && jumlahPaket>= int.MinValue);
            Debug.Assert(hargaPaket <= int.MaxValue && hargaPaket >= int.MinValue);

            // Exception Handling (DESIGN BY CONTRACT)
            int mimimumHarga = checked(jumlahPaket * hargaPaket);

            // past Condition (DESIGN BY CONTRACT)
            return mimimumHarga;
        }
    }
}
