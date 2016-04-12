using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Habitats
{
    interface IArctic
    {
        bool isBelowFreezing { get; set; }
        int volumeOfIce { get; set; }
    }
}
