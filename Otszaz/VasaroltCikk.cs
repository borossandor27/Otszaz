using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Otszaz
{
    class VasaroltCikk
    {
        string cikknev;
        int ertek;

        public VasaroltCikk(string cikknev, int ar)
        {
            this.Cikknev = cikknev;
            this.ertek = ar;
        }

        public string Cikknev { get => cikknev; set => cikknev = value; }
        public int Ertek { get => ertek; set => ertek = value; }
    }
}
