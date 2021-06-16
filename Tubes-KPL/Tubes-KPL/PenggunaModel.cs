using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tubes_KPL
{
    class PenggunaModel
    {
        // Init Variables
        private string _username;
        private string _noHP;
        private string _alamatPengguna;
        private string _email;
        private string _kataSandi;

        // Membuat data pengguna baru dengan data yang berasal dari parameter
        public PenggunaModel(string username, string noHP, string alamatPengguna, string email, string kataSandi)
        {
            try
            {
                _username = username;
                _noHP = noHP;
                _alamatPengguna = alamatPengguna;
                _email = email;
                _kataSandi = kataSandi;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Mengembalikan data _username
        public String getUsername()
        {
            return _username;
        }

        // Menyimpan data _username dengan data data parameter
        public void setUsername(String username)
        {
            this._username = username;
        }

        // Mengembalikan data _noHP
        public String getNoHP()
        {
            return _noHP;
        }

        // Menyimpan data _noHP dengan data data parameter
        public void setNoHP(String noHP)
        {
            this._noHP = noHP;
        }

        // Mengembalikan data _alamatPengguna
        public String getAlamatPengguna()
        {
            return _alamatPengguna;
        }

        // Menyimpan data _alamatPengguna dengan data data parameter
        public void setAlamatPengguna(String alamatPengguna)
        {
            this._alamatPengguna = alamatPengguna;
        }

        // Mengembalikan data _email
        public String getEmail()
        {
            return _email;
        }

        // Menyimpan data _email dengan data data parameter
        public void setEmail(String email)
        {
            this._email = email;
        }

        // Mengembalikan data _kataSandi
        public String getKataSandi()
        {
            return _kataSandi;
        }

        // Menyimpan data _kataSandi dengan data data parameter
        public void setKataSandi(String kataSandi)
        {
            this._kataSandi = kataSandi;
        }
    }
}