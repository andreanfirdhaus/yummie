using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yummie
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Selamat datang di dapur yummie!");
                Console.WriteLine("Apa yang ingin anda masak?");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1. Membuat Roti");
                Console.WriteLine("2. Membuat Pasta");
                Console.WriteLine("3. Membuat Mie");
                Console.WriteLine("4. Membuat MiePasta-Spaghetti");
                Console.WriteLine("5. Exit()");

                Console.Write("Input number. ");
                int pilihan = int.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                switch (pilihan)
                {
                    case 1:
                        Roti roti = new Roti("tepung", 60);
                        Console.WriteLine(roti.Resep());
                        roti.PersiapanBahan();
                        Makanan.PanaskanOven(180); //fitur fungsi class makanan
                        roti.Panggang(20);

                        Console.ReadLine();
                        Console.WriteLine("selamat menikmati makanan anda!");
                        Console.ReadLine();

                        Console.Clear();
                        break;
                    case 2:
                        Pasta pasta = new Pasta("spagheti", "linguine");
                        Console.WriteLine(pasta.Resep());
                        pasta.PersiapanBahan();
                        pasta.Rebus(8);

                        Console.ReadLine();
                        Console.WriteLine("selamat menikmati makanan anda!");
                        Console.ReadLine();

                        Console.Clear();
                        break;
                    case 3:
                        Mie mie = new Mie("mie instan", "rendang");
                        Console.WriteLine(mie.Resep());
                        mie.PersiapanBahan();
                        mie.Rebus(3);

                        Console.ReadLine();
                        Console.WriteLine("selamat menikmati makanan anda!");
                        Console.ReadLine();

                        Console.Clear();
                        break;
                    case 4:
                        MiePasta miepasta = new MiePasta("tepung dan telur", "jamur dan sosis", "spagheti", "rasa BBQ");
                        Console.WriteLine(miepasta.Resep());
                        miepasta.PersiapanBahan();
                        miepasta.Rebus(12);

                        Console.ReadLine();
                        Console.WriteLine("selamat menikmati makanan anda!");
                        Console.ReadLine();

                        Console.Clear();
                        break;
                     case 5:
                        return;
                    default:
                        Console.WriteLine("pilihan tidak tersedia");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                }
                Console.WriteLine();
            }

        }
    }
}
