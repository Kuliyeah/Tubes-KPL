using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class InputTransaksiModel
    {//deklarasi variable
        private String _deskripsiCucian;
        private int _idTransaksi, _idJasa, _totalBayar, _beratCucian, _ongkir;
        private DateTime _tanggal;

        //constructor: membuat data transaksi baru
        public InputTransaksiModel(DateTime tanggal, int idTransaksi, int idJasa,
            String deskripsiCucian, int beratCucian, int ongkir, int totalBayar)
        {
            this._tanggal = tanggal;
            this._idTransaksi = idTransaksi;
            this._idJasa = idJasa;
            this._deskripsiCucian = deskripsiCucian;
            this._beratCucian = beratCucian;
            this._ongkir = ongkir;
            this._totalBayar = totalBayar;
        }

        //(getter)ambil value dari tanggal
        public DateTime getTanggal()
        {
            return _tanggal;
        }

        //(getter)ambil value dari idtoko
        public int getIdTransaksi()
        {
            return _idTransaksi;
        }

        //(getter) ambil value dari idJasa
        public int getIdJasa()
        {
            return _idJasa;
        }

        //(getter) ambil value dari deskripsiCucian
        public String getDeskripsiCucian()
        {
            return _deskripsiCucian;
        }

        //(getter) ambil value dari _beratCucian
        public int getBeratCucian()
        {
            return _beratCucian;
        }

        //(getter) ambil value dari ongkir
        public int getOngkir()
        {
            return _ongkir;
        }

        //(getter) ambil value dari totalBayar
        public int getTotalBayar()
        {
            return _totalBayar;
        }

        //(setter) setting tanggal
        public void setTanggal(DateTime tanggal)
        {
            this._tanggal = tanggal;
        }

        //(setter) setting idTransaksi
        public void setIdTransaksi(int idTransaksi)
        {
            this._idTransaksi = idTransaksi;
        }

        //(setter) setting idJasa
        public void setIdJasa(int idJasa)
        {
            this._idJasa = idJasa;
        }

        //Dzakwan Daffa Hidayatullah - 1302194008
        //(setter) setting deskripsiCucian
        public void setDeskripsiCucian(String deskripsiCucian)
        {
            this._deskripsiCucian = deskripsiCucian;
        }

        //(setter) setting beratCucian
        public void setBeratCucian(int beratCucian)
        {
            this._beratCucian = beratCucian;
        }

        //(setter) setting ongkir
        public void setOngkir(int ongkir)
        {
            this._ongkir = ongkir;
        }

        //(setter) setting idTotalBayar
        public void setTotalBayar(int totalBayar)
        {
            this._totalBayar = totalBayar;
        }
    }
}