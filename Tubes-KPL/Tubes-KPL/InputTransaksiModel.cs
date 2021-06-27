using System;

namespace Tubes_KPL
{
    class InputTransaksiModel
    {
        // Init var.
        private String _deskripsiCucian, _namaJasa;
        private int _idTransaksi, _totalBayar, _beratCucian, _ongkir;
        private DateTime _tanggal;

        // Constructor, membuat data transaksi baru.
        public InputTransaksiModel(DateTime tanggal, int idTransaksi, String namaJasa,
            String deskripsiCucian, int beratCucian, int ongkir, int totalBayar)
        {
            this._tanggal = tanggal;
            this._idTransaksi = idTransaksi;
            this._namaJasa = namaJasa;
            this._deskripsiCucian = deskripsiCucian;
            this._beratCucian = beratCucian;
            this._ongkir = ongkir;
            this._totalBayar = totalBayar;
        }

        // Ambil value dari tanggal.
        public DateTime getTanggal()
        {
            return _tanggal;
        }

        // Ambil value dari idTransaksi.
        public int getIdTransaksi()
        {
            return _idTransaksi;
        }

        // Ambil value dari namaJasa.
        public String getNamaJasa()
        {
            return _namaJasa;
        }

        // Ambil value dari deskripsiCucian.
        public String getDeskripsiCucian()
        {
            return _deskripsiCucian;
        }

        // Ambil value dari beratCucian.
        public int getBeratCucian()
        {
            return _beratCucian;
        }

        // Ambil value dari ongkir.
        public int getOngkir()
        {
            return _ongkir;
        }

        // Ambil value dari totalBayar.
        public int getTotalBayar()
        {
            return _totalBayar;
        }

        // Setting tanggal.
        public void setTanggal(DateTime tanggal)
        {
            this._tanggal = tanggal;
        }

        // Setting idTransaksi.
        public void setIdTransaksi(int idTransaksi)
        {
            this._idTransaksi = idTransaksi;
        }

        // Setting namaJasa.
        public void setNamaJasa(String namaJasa)
        {
            this._namaJasa = namaJasa;
        }

        // Setting deskripsiCucian.
        public void setDeskripsiCucian(String deskripsiCucian)
        {
            this._deskripsiCucian = deskripsiCucian;
        }

        // Setting beratCucian.
        public void setBeratCucian(int beratCucian)
        {
            this._beratCucian = beratCucian;
        }

        // Setting ongkir.
        public void setOngkir(int ongkir)
        {
            this._ongkir = ongkir;
        }

        // Setting idTotalBayar.
        public void setTotalBayar(int totalBayar)
        {
            this._totalBayar = totalBayar;
        }

    }
}