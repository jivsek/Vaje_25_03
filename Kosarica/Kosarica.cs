using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kosarica
{
    internal class Kosarica<T>
    {
        private T objekt;

        public Kosarica(T nek_objekt)
        {
            this.objekt = nek_objekt;
        } 

        public T VrniObjekt() 
        {
            return objekt; 
        }
        
        public void NastaviObjekt(T objekt)
        {
            this.objekt = objekt;
        }

        public override string ToString()
        {
            return objekt.ToString();
        }
    }
}
