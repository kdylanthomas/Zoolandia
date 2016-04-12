using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoolandia.Animals
{
    class PanTroglodytes : Species
    {
        public PanTroglodytes()
        {
            this.url = "https://en.wikipedia.org/wiki/Common_chimpanzee";
            this.genus = new Pan();
            this.scientificName = "Pan Troglodytes";
            this.commonName = "Common Chimpanzee";
        }
    }
}
