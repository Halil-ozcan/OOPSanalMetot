using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPSanalMetot
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri M1 = new Musteri();
            M1.isim = "Halil";
            M1.soyisim = "  Özcan";
            string mesaj = M1.ToString();
            Console.WriteLine(mesaj);
        }
    }
}
