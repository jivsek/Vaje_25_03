using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var registracije = GenerirajRegistracije(100);
            IzpisiRegistracijeZaObmocje(registracije, "LJ");

        }

        static List<Registracija> GenerirajRegistracije(int stevilo)
        {
            List<Registracija> registracije = new List<Registracija>();
            string[] obmocja = { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };
            Random rnd = new Random();

            for (int i = 0; i < stevilo; i++)
            {
                int obmocje_indeks = rnd.Next(obmocja.Length);
                string obmocje = obmocja[obmocje_indeks];
                string registracijska_stevilka = NakljucnaReg(5, rnd);
                registracije.Add(new Registracija(obmocje, registracijska_stevilka));
            }

            return registracije;
        }

        static string NakljucnaReg(int dolzina, Random rnd)
        {
            string znaki = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            char[] niz = new char[dolzina];

            for (int i = 0; i < dolzina; i++)
            {
                int nakljucni_i = rnd.Next(znaki.Length);
                niz[i] = znaki[nakljucni_i];
            }

            return new string(niz);
        }

        static void IzpisiRegistracijeZaObmocje(List<Registracija> registracije, string obmocje)
        {
            var filtrirane = registracije.Where(reg => reg.obmocje == obmocje);
            Console.WriteLine($"Registracije za območje {obmocje}:");
            foreach (var reg in filtrirane)
            {
                Console.WriteLine(reg.RegistracijskaTablica());
            }
        }
     
    }
}
