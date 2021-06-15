using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class InputJasaModel
    {
        String namaToko, namaJasa, deskripsi;
        int harga;

        public InputJasaModel(string namaToko, string namaJasa, int harga, string deskripsi)
        {
            this.namaToko = namaToko;
            this.namaJasa = namaJasa;
            this.deskripsi = deskripsi;
            this.harga = harga;
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
        public void setHarga(int harga)
        {
            this.harga = harga;
        }
        public int getHarga()
        {
            return this.harga;
        }
        public void setDeskripsi(String deskripsi)
        {
            this.deskripsi = deskripsi;
        }
        public String getDeskripsi()
        {
            return this.deskripsi;
        }
    }
}
