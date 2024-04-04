using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Registracija
{
    public class Registracija
    {
        public string obmocje { get; set; }
        public string registracijska_stevilka { get; set; }

        private static HashSet<string> veljavna_obmocja = new HashSet<string> { "LJ", "KR", "KK", "MB", "MS", "KP", "GO", "CE", "SG", "NM", "PO" };

        public Registracija(string obmocje, string registracijska)
        {
            if (obmocje.Length != 2 || !JeIzCrk(obmocje))
            {
                throw new ArgumentException("Območje mora biti iz dveh črk.");
            }

            if (!veljavna_obmocja.Contains(obmocje))
            {
                throw new ArgumentException("Neveljavno območje.");
            }

            if (registracijska.Length != 5 || JeIzCrkInStevk(registracijska))
            {
                throw new ArgumentException("Registracijska številka mora biti iz petih črk ali števk.");
            }

            this.obmocje = obmocje;
            this.registracijska_stevilka = registracijska;
        }

        public bool JeIzCrk(string obmocje)
        {
            foreach (char c in obmocje)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }

        public bool JeIzCrkInStevk(string registracijska)
        {
            foreach (char c in registracijska)
            {
                if (!char.IsLetter(c) || !char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public string RegistracijskaTablica()
        {
            return $"{obmocje} {registracijska_stevilka}";
        }
    }
}
