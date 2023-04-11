using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace yummie
{
    // M. Andrean N. F_19.11.3182
    internal class MiePasta : Makanan
    {
        private string topping;
        private Mie mie;
        private Pasta pasta;

        public MiePasta(string bahanUtama, string topping, string bentuk, string rasa) : base(bahanUtama)
        {
            this.topping = topping;
            pasta = new Pasta(bahanUtama, bentuk);
            mie = new Mie(bahanUtama, rasa);
        }

        public override string Resep()
        {
            return "Ini adalah resep MiePasta:";
        }

        public void PersiapanBahan()
        {
            pasta.PersiapanBahan();
        }

        public void Rebus(int waktu)
        {
            mie.Rebus(waktu);
            Console.WriteLine($"-> Tiriskan dan sajikan dengan topping {topping}.");
        }

    }
}
