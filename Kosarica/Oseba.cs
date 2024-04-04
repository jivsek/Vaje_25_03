using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica
{
    internal class Oseba
    {
        public string ime { get; set; }
        public int starost { get; set; }

        public Oseba(string ime, int starost)
        {
            this.ime = ime;
            this.starost = starost;
        }

        public override string ToString()
        {
            return $"Ime: {ime}, Starost: {starost}";
        }
    }
}
