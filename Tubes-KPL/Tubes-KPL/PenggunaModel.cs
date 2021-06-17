using System;

namespace Tubes_KPL
{
    class PenggunaModel
    {
        // Init Variables
        public string username;
        public string noHP;
        public string alamatPengguna;
        public string email;
        public string kataSandi;

        public PenggunaModel(){}

        // Membuat data pengguna baru dengan data yang berasal dari parameter
        public PenggunaModel(string username, string noHP, string alamatPengguna, string email, string kataSandi)
        {
            try
            {
                this.username = username;
                this.noHP = noHP;
                this.alamatPengguna = alamatPengguna;
                this.email = email;
                this.kataSandi = kataSandi;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        // Mengembalikan data username
        public String getUsername()
        {
            return username;
        }

        // Menyimpan data username dengan data data parameter
        public void setUsername(String username)
        {
            this.username = username;
        }

        // Mengembalikan data noHP
        public String getNoHP()
        {
            return noHP;
        }

        // Menyimpan data noHP dengan data data parameter
        public void setNoHP(String noHP)
        {
            this.noHP = noHP;
        }

        // Mengembalikan data alamatPengguna
        public String getAlamatPengguna()
        {
            return alamatPengguna;
        }

        // Menyimpan data alamatPengguna dengan data data parameter
        public void setAlamatPengguna(String alamatPengguna)
        {
            this.alamatPengguna = alamatPengguna;
        }

        // Mengembalikan data email
        public String getEmail()
        {
            return email;
        }

        // Menyimpan data email dengan data data parameter
        public void setEmail(String email)
        {
            this.email = email;
        }

        // Mengembalikan data kataSandi
        public String getKataSandi()
        {
            return kataSandi;
        }

        // Menyimpan data kataSandi dengan data data parameter
        public void setKataSandi(String kataSandi)
        {
            this.kataSandi = kataSandi;
        }
    }
}