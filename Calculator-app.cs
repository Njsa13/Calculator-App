using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Latihan1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Aplikasi Calculator";

            //int a = 10;
            //int b = 6 ;
            Console.WriteLine("Pilih menu calculator : ");
            Console.WriteLine("1. Pertambahan");
            Console.WriteLine("2. Pengurangan");
            Console.WriteLine("3. Perkalian");
            Console.WriteLine("4. Pembagian");

            Console.WriteLine("\nInput nomor menu [1...4] :");
            int pilih = Convert.ToInt32(Console.ReadLine());

            switch (pilih)
            {                             
                case 1:
                    Console.WriteLine("\nInputkan nilai a =");
                    int a = int.Parse(Console.ReadLine());        //Proses penginputan ada 2 cara
                    Console.WriteLine("Inputkan nilai b =");     //Hasil inputan akan di convert terlebih dahulu ke int
                    int b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Pertambahan " + a + " + " + b + " = " + Penambahan(a, b)); //Cara output ada dua
                    break;
                case 2:
                    Console.WriteLine("\nInputkan nilai a =");
                    a = int.Parse(Console.ReadLine());        //Proses penginputan ada 2 cara
                    Console.WriteLine("Inputkan nilai b =");     //Hasil inputan akan di convert terlebih dahulu ke int
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Pengurangan {0} - {1} = {2} ", a, b, Pengurangan(a, b));
                    break;
                case 3:
                    Console.WriteLine("\nInputkan nilai a =");
                    a = int.Parse(Console.ReadLine());        //Proses penginputan ada 2 cara
                    Console.WriteLine("Inputkan nilai b =");     //Hasil inputan akan di convert terlebih dahulu ke int
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Perkalian {0} * {1} = {2} ", a, b, Perkalian(a, b));
                    break;
                case 4:
                    Console.WriteLine("\nInputkan nilai a =");
                    a = int.Parse(Console.ReadLine());        //Proses penginputan ada 2 cara
                    Console.WriteLine("Inputkan nilai b =");     //Hasil inputan akan di convert terlebih dahulu ke int
                    b = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("\nHasil Pembagian {0} / {1} = {2} ", a, b, Pembagian(a, b));
                    break;
                default:
                    Console.WriteLine("\nMaaf, menu yang anda pilih tidak tersedia");
                    break;
            }

            Console.WriteLine("\nTekan Enter untuk keluar");
            Console.ReadKey();
        }

        static int Penambahan(int a, int b)
        {
            return a + b;
        }

        static int Pengurangan(int a, int b)
        {
            return a - b;
        }

        static int Perkalian(int a, int b)
        {
            return a * b;
        }

        static int Pembagian(int a, int b)
        {
            return a / b;
        }
    }
}
