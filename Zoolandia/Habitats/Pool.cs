using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia.Habitats
{
    class Pool : Habitat, IAquatic
    {
        public int salinity { get; set; }
    }
}
