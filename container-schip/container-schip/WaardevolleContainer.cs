using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container_schip
{
    public class WaardevolleContainer
    {
        public int Z { get; set; }
        public double Gewicht { get; set; }

        public WaardevolleContainer(int z, double gewicht)
        {
            this.Z = z;
            this.Gewicht = gewicht;
        }

        public bool Valideren(HoogteBreedte hb)
        {
            if (!hb.Containers.Contains(this))
            {
                throw new ArgumentException("error");
            }
            return hb.Containers.Max(x => x.Z) == Z && hb.Containers.Count(c => c is WaardevolleContainer) == 1;
        }
        public int VerdeeldeHoogte(HoogteBreedte hb)
        {
            return hb.Containers.Count();
        }

        public void ZetZ(HoogteBreedte hb, int z)
        {
            if (!hb.Containers.Contains(this))
            {
                throw new ArgumentException("error");
            }
            else if (z == hb.Containers.Count)
            {
                Z = z;
            }
        }

        //methods
        public override string ToString()
        {
            return $" Waardevolle + {Math.Round(Gewicht)}";
        }
    }
}
