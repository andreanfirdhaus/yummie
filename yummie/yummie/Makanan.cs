using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yummie
{
    internal class Makanan
    {
        protected string bahanUtama;

        public Makanan(string bahanUtama)
        {
            this.bahanUtama = bahanUtama;
        }

        public virtual string Resep()
        {
            return "ini adalah resep makanan.";
        }

        public virtual void PersiapanBahan()
        {
            Console.WriteLine($"-> Siapkan{bahanUtama} sebagai bahan utama.");
        }

        public static void PanaskanOven(int suhu)
        {
            Console.WriteLine($"-> Panaskan oven pada suhu {suhu}°C.");
        }
    }
}
