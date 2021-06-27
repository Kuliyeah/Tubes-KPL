using System;

namespace Tubes_KPL
{
    class SingletonPattern
    {
        public enum Status { // komponen pada enum status
            Empty, Pendataan, Pemrosesan, Pembayaran
        }

        private static readonly Lazy<SingletonPattern> _singleton = new Lazy<SingletonPattern>(() => new SingletonPattern());

        public static SingletonPattern GetInstance() => _singleton.Value;

        private Status _homepage; //method homepage

        private SingletonPattern() // kondisi dimana pada tampilan masih kosong
        {
            Console.WriteLine("login");
            _homepage = Status.Empty;
        }

        public void inputPengguna() // kondisi dimana pada tampilan input pengguna status sebagai pendataan
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi data");
            _homepage = Status.Pendataan;
        }

        public void inputJasa() // kondisi dimana pada tampilan input jasa status sebagai pemrosesan
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi jasa");
            _homepage = Status.Pemrosesan;
        }

        public void inputTransaksi() // kondisi dimana pada tampilan input transaksi status sebagai pembayaran
        {
            if (IsPembayaran || IsEmpty) return;
            Console.WriteLine("bayar");
            _homepage = Status.Pembayaran;
        }

        private bool IsEmpty => (_homepage == Status.Empty);

        private bool IsPembayaran => (_homepage == Status.Pembayaran);
    }
}

