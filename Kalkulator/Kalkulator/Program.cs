using System;

namespace Kalkulator
{
    public class Program
    {
        public static double HitungHasil(double[] angka, int[] operatorInput)
        {
            double hasil = angka[0];

            // Melakukan operasi yang dipilih oleh pengguna
            for (int j = 1; j < angka.Length; j++)
            {
                switch (operatorInput[j - 1])
                {
                    case 1:
                        hasil += angka[j];
                        break;
                    case 2:
                        hasil -= angka[j];
                        break;
                    case 3:
                        hasil *= angka[j];
                        break;
                    case 4:
                        if (angka[j] == 0)
                        {
                            Console.WriteLine("Tidak bisa melakukan pembagian dengan nol.");
                            return double.NaN;
                        }
                        hasil /= angka[j];
                        break;
                }
            }

            return hasil;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Selamat datang di Program Kalkulator\n");

            do
            {
                Console.Write("Masukkan jumlah angka yang akan dioperasikan: ");
                int jumlahAngka;

                if (!int.TryParse(Console.ReadLine(), out jumlahAngka) || jumlahAngka < 2)
                {
                    Console.WriteLine("Input jumlah angka salah. Silakan masukkan angka yang valid (minimal 2).");
                    continue;
                }

                double[] angka = new double[jumlahAngka];
                for (int i = 0; i < jumlahAngka; i++)
                {
                    Console.Write("Masukkan angka ke-" + (i + 1) + ": ");
                    if (!double.TryParse(Console.ReadLine(), out angka[i]))
                    {
                        Console.WriteLine("Input salah. Silakan masukkan angka.");
                        i--;
                    }
                }

                Console.WriteLine("\nSilakan masukkan operasi yang akan dilakukan:");

                // Menampilkan pilihan operasi
                Console.WriteLine("(1) Penjumlahan");
                Console.WriteLine("(2) Pengurangan");
                Console.WriteLine("(3) Perkalian");
                Console.WriteLine("(4) Pembagian");

                int[] validOperator = { 1, 2, 3, 4 };
                int[] operatorInput = new int[jumlahAngka - 1];

                // Meminta pengguna memilih operasi
                for (int i = 0; i < jumlahAngka - 1; i++)
                {
                    Console.Write("Masukkan operasi ke-" + (i + 1) + " (1-4): ");
                    if (!int.TryParse(Console.ReadLine(), out operatorInput[i]) || Array.IndexOf(validOperator, operatorInput[i]) < 0)
                    {
                        Console.WriteLine("Input operator salah. Silakan masukkan operator yang valid.");
                        i--;
                    }
                }

                double hasil = HitungHasil(angka, operatorInput);
                if (!double.IsNaN(hasil))
                {
                    Console.WriteLine("\nHasil: " + hasil);
                }

                // Menanyakan apakah pengguna ingin mengulang program atau keluar
                Console.WriteLine("\nApakah Anda ingin mengulang program? (Y/N)");
                string ulang = Console.ReadLine();
                if (ulang == "Y" || ulang == "y")
                {
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nTerima kasih telah menggunakan Program Kalkulator.");
                    Console.ReadKey();
                    return;
                }
            } while (true);
        }
    }
}
