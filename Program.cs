using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace latihanclassdanobjek
{
    class Program
    {
        static void Main(string[] args)
        {
            Mahasiswa mhs = new Mahasiswa(); //membuat objek class dari Mahasiswa
            Mahasiswa mhs2 = new Mahasiswa();
            mhs.Nama = "Vian"; //mengeset nilai properties objek mhs
            mhs.Nim = "1811";
            mhs.Ipk = 3.92f;

            mhs2.Nama = "Gosani"; //mengeset nilai properties objek mhs2
            mhs2.Nim = "2324";
            mhs2.Ipk = 3.5f;

            mhs.Registrasi(); //memanggil method registrasi
            mhs.IsiKrs(); //memanggil method isikrs

            mhs2.Registrasi();
            mhs2.IsiKrs();

            Console.ReadKey();
        }
    }
}
