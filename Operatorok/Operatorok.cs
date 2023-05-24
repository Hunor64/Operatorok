using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Operatorok
{
    internal class Operatorok
    {
        string sor;
        int elsoElem;
        string operatorJel;
        int masodikElem;
        public Operatorok(string sor)
        {
            this.sor = sor;
            var felbont = sor.Split(' ');
            this.elsoElem = int.Parse(felbont[0]);
            this.operatorJel = felbont[1];
            this.masodikElem = int.Parse(felbont[2]);

        }

        public string Sor { get => sor; }
        public int ElsoElem { get => elsoElem; }
        public string OperatorJel { get => operatorJel; }
        public int MasodikElem { get => masodikElem; }

    }
}
