using System;

namespace Tubes_KPL
{
    //Adamnn.
    class SingletonPattern
    {
        // Komponen pada enum status.
        public enum Status { 
            Empty, Pendataan, Pemrosesan, Pembayaran
        }

        private static readonly Lazy<SingletonPattern> _singleton = new Lazy<SingletonPattern>(() => new SingletonPattern());

        public static SingletonPattern GetInstance() => _singleton.Value;

        // Method homepage.
        private Status _homepage;

        // Kondisi dimana pada tampilan masih kosong.
        private SingletonPattern() 
        {
            Console.WriteLine("login");
            _homepage = Status.Empty;
        }

        // Kondisi dimana pada tampilan input pengguna status sebagai pendataan.
        public void inputPengguna() 
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi data");
            _homepage = Status.Pendataan;
        }

        // Kondisi dimana pada tampilan input jasa status sebagai pemrosesan.
        public void inputJasa() 
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi jasa");
            _homepage = Status.Pemrosesan;
        }

        // Kondisi dimana pada tampilan input transaksi status sebagai pembayaran.
        public void inputTransaksi() 
        {
            if (IsPembayaran || IsEmpty) return;
            Console.WriteLine("bayar");
            _homepage = Status.Pembayaran;
        }

        private bool IsEmpty => (_homepage == Status.Empty);

        private bool IsPembayaran => (_homepage == Status.Pembayaran);
    }
}

