using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace container_schip
{
    public class HoogteBreedte
    {
        private List<WaardevolleContainer> containers;
        public int Y { get; private set; }
        public int X { get; private set; }

        public IReadOnlyCollection<WaardevolleContainer> Containers
        {
            get { return containers.AsReadOnly(); }
        }
    }
}
