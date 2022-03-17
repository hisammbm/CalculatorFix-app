using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorFinal;

class program{
    static void Main(string[] args)
    {
        int A, B, Pilihan;
        Console.Title = "CALCULATOR SEDERHANA";

        Console.WriteLine("=====KALKULATOR SEDERHANA=====");
        Console.WriteLine("1) Penambahan");
        Console.WriteLine("2) Pengurangan");
        Console.WriteLine("3) Perkalian");
        Console.WriteLine("4) Pembagian");
        Console.WriteLine("==============================");
        Console.Write("Masukan Pilihan Anda = "); 
        Pilihan = Convert.ToInt32(Console.ReadLine());


        if (Pilihan == 1){
            Console.Write("Inputkan Nilai A = ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Penambahan " + A + " + " + B + " = " + Penambahan(A, B));

        }else if (Pilihan == 2){
            Console.Write("Inputkan Nilai A = ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Pengurangan " + A + " - " + B + " = " + Pengurangan(A, B));

        }else if (Pilihan == 3){
            Console.Write("Inputkan Nilai A = ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Perkalian " + A + " x " + B + " = " + Perkalian(A, B));

        }else if (Pilihan == 4){
            Console.Write("Inputkan Nilai A = ");
            A = Convert.ToInt32(Console.ReadLine());

            Console.Write("Inputkan Nilai B = ");
            B = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hasil Pembagian " + A + " / " + B + " = " + Pembagian(A, B));

        }else{
            Console.WriteLine();
            Console.WriteLine("Maaf pilihan tidak tersedia");
        }

        Console.WriteLine();
        Console.Write("Tekan Sembarang Key Untuk Keluar");
        Console.ReadKey();

    }

    static int Penambahan(int a, int b){
        return a + b;
    }
    static int Pengurangan(int a, int b){
        return a - b;
    }
    static int Perkalian(int a, int b){
        return a * b;
    }
    static int Pembagian(int a, int b){
        return a / b;
    }


}
