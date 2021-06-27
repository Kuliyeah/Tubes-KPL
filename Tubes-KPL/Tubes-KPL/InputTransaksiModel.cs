using System;

namespace Tubes_KPL
{
    public class InputTransaksiModel
    {
        // Init var.
        private String deskripsiCucian, namaJasa;
        private int idTransaksi, totalBayar, beratCucian, ongkir;
        private DateTime tanggal;

        // Constructor, membuat data transaksi baru.
        public InputTransaksiModel(DateTime tanggal, int idTransaksi, String namaJasa,
            String deskripsiCucian, int beratCucian, int ongkir, int totalBayar)
        {
            this.tanggal = tanggal;
            this.idTransaksi = idTransaksi;
            this.namaJasa = namaJasa;
            this.deskripsiCucian = deskripsiCucian;
            this.beratCucian = beratCucian;
            this.ongkir = ongkir;
            this.totalBayar = totalBayar;
        }

        // Ambil value dari tanggal.
        public DateTime getTanggal()
        {
            return tanggal;
        }

        // Ambil value dari idTransaksi.
        public int getIdTransaksi()
        {
            return idTransaksi;
        }

        // Ambil value dari namaJasa.
        public String getNamaJasa()
        {
            return namaJasa;
        }

        // Ambil value dari deskripsiCucian.
        public String getDeskripsiCucian()
        {
            return deskripsiCucian;
        }

        // Ambil value dari beratCucian.
        public int getBeratCucian()
        {
            return beratCucian;
        }

        // Ambil value dari ongkir.
        public int getOngkir()
        {
            return ongkir;
        }

        // Ambil value dari totalBayar.
        public int getTotalBayar()
        {
            return totalBayar;
        }

        // Setting tanggal.
        public void setTanggal(DateTime tanggal)
        {
            this.tanggal = tanggal;
        }

        // Setting idTransaksi.
        public void setIdTransaksi(int idTransaksi)
        {
            this.idTransaksi = idTransaksi;
        }

        // Setting namaJasa.
        public void setNamaJasa(String namaJasa)
        {
            this.namaJasa = namaJasa;
        }

        // Setting deskripsiCucian.
        public void setDeskripsiCucian(String deskripsiCucian)
        {
            this.deskripsiCucian = deskripsiCucian;
        }

        // Setting beratCucian.
        public void setBeratCucian(int beratCucian)
        {
            this.beratCucian = beratCucian;
        }

        // Setting ongkir.
        public void setOngkir(int ongkir)
        {
            this.ongkir = ongkir;
        }

        // Setting idTotalBayar.
        public void setTotalBayar(int totalBayar)
        {
            this.totalBayar = totalBayar;
        }

    }
}