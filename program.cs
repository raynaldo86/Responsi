using System;

namespace ResponsiPemrograman2605
{
    class Program
    {
        static void Main(string[] args)
        {



            Karyawan karyawan = new Karyawan(19032123, "Bambang", 3000000);
            Karyawan karyawan2 = new Karyawan(19032124, "Alex", 4000000);


            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.showKaryawan();
            karyawan2.showKaryawan();

            Console.WriteLine("\n\n Horeee naik gaji lur");

            Console.WriteLine("NIK \t Nama \t Gaji");
            Console.WriteLine("--------------------------");
            karyawan.naikGaji();
            karyawan2.naikGaji();

            Console.ReadKey();
        }
    }