using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    class Arctic : Habitat, IArctic
    {
        public bool isBelowFreezing { get; set; }

        public int volumeOfIce { get; set; }
    }
}
