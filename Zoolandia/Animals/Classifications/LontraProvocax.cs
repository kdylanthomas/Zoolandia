using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class LontraProvocax : Species
    {
        public LontraProvocax()
        {
            this.url = "https://en.wikipedia.org/wiki/Southern_river_otter";
            this.genus = new Lontra();
            this.scientificName = "Lontra Provocax";
            this.commonName = "Southern River Otter";
        }
    }
}
