using System;

namespace Tubes_KPL
{
    class SingletonPattern
    {
        public enum Status {
            Empty, Pendataan, Pemrosesan, Pembayaran
        }

        private static readonly Lazy<SingletonPattern> _singleton = new Lazy<SingletonPattern>(() => new SingletonPattern());

        public static SingletonPattern GetInstance() => _singleton.Value;

        private Status _homepage;

        private SingletonPattern()
        {
            Console.WriteLine("login");
            _homepage = Status.Empty;
        }

        public void inputPengguna()
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi data");
            _homepage = Status.Pendataan;
        }

        public void inputJasa()
        {
            if (!IsEmpty) return;
            Console.WriteLine("isi jasa");
            _homepage = Status.Pemrosesan;
        }

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

