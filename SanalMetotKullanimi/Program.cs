using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SanalMetotKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun = new Urun();
            urun.EkranaYazdir("Ürün nesnesini içerisindeki metot çağrıldı");

            baseClass baseClass = new baseClass();
            baseClass.EkranaYazdir("baseclass nesnesi içerisindeki bu metot çağrıldı");
        }
    }
}
