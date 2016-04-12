using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class LontraFelina : Species
    {
        public LontraFelina()
        {
            this.url = "https://en.wikipedia.org/wiki/Marine_otter";
            this.genus = new Lontra();
            this.scientificName = "Lontra Felina";
            this.commonName = "Marine Otter";
        }
    }
}
