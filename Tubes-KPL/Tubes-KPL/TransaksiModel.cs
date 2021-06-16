using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class TransaksiModel
    {//deklarasi variable
        private String _deskripsiCucian;
        private int _idTransaksi, _idJasa, _idDetailStatus, _totalBayar, _beratCucian, _ongkir, _bayar;

        //constructor: membuat data transaksi baru
        public TransaksiModel(int idTransaksi, int idJasa, int _idDetailStatus,
            String deskripsiCucian, int _beratCucian, int _ongkir,
            int bayar, int totalBayar)
        {
            this._idTransaksi = _idTransaksi;
            this._idJasa = _idJasa;
            this._idDetailStatus = _idDetailStatus;
            this._deskripsiCucian = _deskripsiCucian;
            this._beratCucian = _beratCucian;
            this._ongkir = _ongkir;
            this._bayar = _bayar;
            this._totalBayar = _totalBayar;
        }

        //(getter)ambil value dari idtoko
        public int getidTransaksi()
        {
            return _idTransaksi;
        }

        //Dzakwan Daffa Hidayatullah - 1302194008
        //(getter) ambil value dari idJasa
        public int getidJasa()
        {
            return _idJasa;
        }

        //(getter) ambil value dari _idDetailStatus
        public int getidDetailStatus()
        {
            return _idDetailStatus;
        }

        //(getter) ambil value dari deskripsiCucian
        public String getdeskripsiCucian()
        {
            return _deskripsiCucian;
        }

        //(getter) ambil value dari _beratCucian
        public int getberatCucian()
        {
            return _beratCucian;
        }

        //(getter) ambil value dari ongkir
        public int getongkir()
        {
            return _ongkir;
        }

        //Dzakwan Daffa Hidayatullah - 1302194008
        //(getter) ambil value dari bayar
        public int getBayar()
        {
            return _bayar;
        }

        //(getter) ambil value dari totalBayar
        public int getTotalBayar()
        {
            return _totalBayar;
        }

        //(setter) setting idTransaksi
        public void setidTransaksi(int idTransaksi)
        {
            this._idTransaksi = _idTransaksi;
        }

        //(setter) setting idJasa
        public void setidJasa(int idJasa)
        {
            this._idJasa = _idJasa;
        }

        //(setter) setting idDetailStatus
        public void setidDetailStatus(int idDetailStatus)
        {
            this._idDetailStatus = _idDetailStatus;
        }

        //Dzakwan Daffa Hidayatullah - 1302194008
        //(setter) setting deskripsiCucian
        public void setdeskripsiCucian(String deskripsiCucian)
        {
            this._deskripsiCucian = _deskripsiCucian;
        }

        //(setter) setting beratCucian
        public void setberatCucian(int beratCucian)
        {
            this._beratCucian = _beratCucian;
        }

        //(setter) setting ongkir
        public void setongkir(int ongkir)
        {
            this._ongkir = _ongkir;
        }

        //(setter) setting bayar
        public void setBayar(int bayar)
        {
            this._bayar = _bayar;
        }

        //(setter) setting idTotalBayar
        public void setTotalBayar(int totalBayar)
        {
            this._totalBayar = _totalBayar;
        }
    }
}