using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class LontraCanadensis : Species
    {
        public LontraCanadensis()
        {
            this.url = "https://en.wikipedia.org/wiki/North_American_river_otter";
            this.genus = new Lontra();
            this.scientificName = "Lontra Canadensis";
            this.commonName = "North American River Otter";
        }
    }
}
