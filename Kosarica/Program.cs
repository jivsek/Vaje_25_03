using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Kosarica<string> niz = new Kosarica<string>("Testni niz");
            Kosarica<int> celoStevilo = new Kosarica<int>(77);
            Kosarica<Oseba> oseba = new Kosarica<Oseba>(new Oseba("Jure", 22));
            Kosarica<double> realnoStevilo = new Kosarica<double>(3.14);
            Kosarica<int[]> tabelaStevil = new Kosarica<int[]>(new int[] { 1, 2, 3, 4 });

            Console.WriteLine(niz);
            Console.WriteLine(celoStevilo);
            Console.WriteLine(oseba);
            Console.WriteLine(realnoStevilo);
            Console.WriteLine(tabelaStevil);

        }
    }
}
