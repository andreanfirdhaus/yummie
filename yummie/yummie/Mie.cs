﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace yummie
{
    internal class Mie : Makanan
    {
        private string rasa;

        public Mie(string bahanUtama, string rasa) : base(bahanUtama)
        {
            this.rasa = rasa;
        }

        public override string Resep()
        {
            return "Ini adalah resep mie:";        
        }

        public void Rebus(int waktu)
        {
            Console.WriteLine($"-> Rebus mie selama {waktu} menit dengan tambahan bumbu {rasa}.");
        }

        public override void PersiapanBahan()
        {
            Console.WriteLine($"-> Siapkan {bahanUtama} sebagai bahan utama.");
            Console.WriteLine($"-> Tambahkan bumbu {rasa} ke dalam air rebusan mie.");
        }
    }
}
