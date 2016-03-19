using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    public class Kalkulator
    {
        public int Dodaj(int lewa, int prawa)
        {
            return lewa + prawa;
        }

        public int Odejmij(int lewa, int prawa)
        {
            return lewa - prawa;
        }

        public int Modulo(int lewa, int prawa)
        {
            return lewa % prawa;
        }
    }
}
