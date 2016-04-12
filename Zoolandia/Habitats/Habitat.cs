using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoolandia.Animals;

namespace Zoolandia
{
    class Habitat
    {
        public bool isOutside;
        public bool isAquatic;
        public double baseTemperature;
        public double width;
        public double depth;
        public double height;
        public int windowCount;
        public string climateType;

        // aggregate animals into habitat with list--each item in list is a type
        public List<Animal> inhabitants;
    }
}
